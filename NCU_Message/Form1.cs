using HtmlAgilityPack;
using System;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace NCU_Message
{
    public partial class NCU_MSG : Form
    {
        HtmlAgilityPack.HtmlDocument doc,doc2,doc3;
        HtmlNodeCollection list,list2,list3;
        HtmlWeb webClient = new HtmlWeb(); //建立htmlweb
        bool page2 = false;
        List<string> myList = new List<string>();
        List<string> myList2 = new List<string>();
        string filename;

        public NCU_MSG()
        {
            InitializeComponent();
            string folder = System.IO.Directory.GetCurrentDirectory();
            filename = folder + "\\data.txt";
            if (File.Exists(filename))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);
                string get_data;

                get_data = file.ReadLine();

                while (get_data != null)
                {
                    Show3.Items.Add(get_data);
                    get_data = file.ReadLine();
                }
                file.Close();
            }

            try
            {
                //處理C# 連線 HTTPS 網站發生驗證失敗導致基礎連接已關閉
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls |
                SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                
                doc2 = webClient.Load("https://service-learning.ncu.edu.tw/pass_new_activity.php?page=1"); //載入網址資料
                list2 = doc2.DocumentNode.SelectNodes("//*[@id='main']/p/a"); //抓取Xpath資料

                for (int j = 0; j < list2.Count; j++)
                {
                    doc = webClient.Load("https://service-learning.ncu.edu.tw/pass_new_activity.php?page="+(j+1)); //載入網址資料
                    list = doc.DocumentNode.SelectNodes("//*[@id='welcome']/div[2]/div"); //抓取Xpath資料

                    for (int i = 2; i < list.Count; i++)
                    {
                        var time = list[i].SelectSingleNode("div[1]/text()");
                        var kind = list[i].SelectSingleNode("div[2]/text()");
                        var title = list[i].SelectSingleNode("div[3]/a/text()");
                        var html = list[i].SelectSingleNode("div[3]/a");

                        if (time != null)
                        {
                            if (time_check(delete_s(time.InnerText)) == 1)
                            {
                                string text = delete_s(time.InnerText) + "  " + delete_s(kind.InnerText) + "  " + delete_s(title.InnerText);
                                Show.Items.Add(text);
                                myList.Add(html.Attributes[0].Value);
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR=" + ex.ToString());
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (page2 == false)
            {
                try
                {
                    doc3 = webClient.Load("https://www.me.ncu.edu.tw/News/index.php?id=1"); //載入網址資料
                    list3 = doc3.DocumentNode.SelectNodes("/html/body/div/div[5]/table[3]//tr"); //抓取Xpath資料

                    for (int i = 4; i < list3.Count; i++)
                    {
                        var time = list3[i].SelectSingleNode("td[2]/text()");
                        var title = list3[i].SelectSingleNode("td[4]/a/text()");
                        var html = list3[i].SelectSingleNode("td[4]/a");

                        if (time != null)
                        {
                            string text = delete_s(time.InnerText) + "  " + delete_s(title.InnerText);
                            Show2.Items.Add(text);
                            myList2.Add(html.Attributes[0].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR=" + ex.ToString());
                }
            }
            page2 = true;
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (Show.SelectedIndex >= 0)
            {
                string s = "https://service-learning.ncu.edu.tw/" + myList[Show.SelectedIndex];
                System.Diagnostics.Process.Start(s);
            }
        }

        private void go2_Click(object sender, EventArgs e)
        {
            if (Show2.SelectedIndex >= 0)
            {
                string s = "https://www.me.ncu.edu.tw/News/" + myList2[Show2.SelectedIndex];
                System.Diagnostics.Process.Start(s);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Show2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void Show_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NCU_MSG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Show3.Items.Count != 0)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
                for (int i = 0; i < Show3.Items.Count; i++)
                {
                    file.WriteLine(Show3.Items[i].ToString());
                }
                file.Close();
            }
        }

        private void add_data_Click(object sender, EventArgs e)
        {
            if(Show.SelectedIndex >= 0)
              Show3.Items.Add(Show.SelectedItem);
        }

        private void add_data2_Click(object sender, EventArgs e)
        {
            if (Show2.SelectedIndex >= 0)
              Show3.Items.Add(Show2.SelectedItem);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (Show3.SelectedIndex >= 0)
              Show3.Items.RemoveAt(Show3.SelectedIndex); 
        }

        string delete_s(string html) {
            html = Regex.Replace(html, "[\f\n\r\t\v]", "");
            return html;
        }

        DateTime date1 = DateTime.Now;
        string[] subs;

        int time_check(string time)
        {
            subs = time.Split('-');

            if (int.Parse(subs[0]) == int.Parse(date1.Year.ToString()))
            {
                if (int.Parse(subs[1]) == int.Parse(date1.Month.ToString()))
                {
                    if (int.Parse(subs[2]) >= int.Parse(date1.Day.ToString()))
                    {
                        return 1;
                    }
                    else
                    {
                      return 0;
                    }
                }
                else
                {
                    if (int.Parse(subs[1]) > int.Parse(date1.Month.ToString()))
                        return 1;
                    else
                        return 0;
                }
            }
            else
            {
                if (int.Parse(subs[0]) > int.Parse(date1.Year.ToString()))
                    return 1;
                else
                    return 0;
            }
        }
    }
}
