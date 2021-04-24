namespace NCU_Message
{
    partial class NCU_MSG
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Show = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add_data = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_data2 = new System.Windows.Forms.Button();
            this.go2 = new System.Windows.Forms.Button();
            this.Show2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.Show3 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.FormattingEnabled = true;
            this.Show.ItemHeight = 23;
            this.Show.Location = new System.Drawing.Point(6, 60);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(879, 395);
            this.Show.TabIndex = 0;
            this.Show.SelectedIndexChanged += new System.EventHandler(this.Show_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "最新認證活動";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 495);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.add_data);
            this.tabPage1.Controls.Add(this.go);
            this.tabPage1.Controls.Add(this.Show);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時數";
            // 
            // add_data
            // 
            this.add_data.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_data.Location = new System.Drawing.Point(657, 13);
            this.add_data.Name = "add_data";
            this.add_data.Size = new System.Drawing.Size(133, 33);
            this.add_data.TabIndex = 3;
            this.add_data.Text = "新增自選";
            this.add_data.UseVisualStyleBackColor = true;
            this.add_data.Click += new System.EventHandler(this.add_data_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(810, 11);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 37);
            this.go.TabIndex = 2;
            this.go.Text = "前往";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_data2);
            this.tabPage2.Controls.Add(this.go2);
            this.tabPage2.Controls.Add(this.Show2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "機械系辦";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // add_data2
            // 
            this.add_data2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_data2.Location = new System.Drawing.Point(663, 6);
            this.add_data2.Name = "add_data2";
            this.add_data2.Size = new System.Drawing.Size(133, 35);
            this.add_data2.TabIndex = 4;
            this.add_data2.Text = "新增自選";
            this.add_data2.UseVisualStyleBackColor = true;
            this.add_data2.Click += new System.EventHandler(this.add_data2_Click);
            // 
            // go2
            // 
            this.go2.Location = new System.Drawing.Point(815, 6);
            this.go2.Name = "go2";
            this.go2.Size = new System.Drawing.Size(75, 37);
            this.go2.TabIndex = 3;
            this.go2.Text = "前往";
            this.go2.UseVisualStyleBackColor = true;
            this.go2.Click += new System.EventHandler(this.go2_Click);
            // 
            // Show2
            // 
            this.Show2.FormattingEnabled = true;
            this.Show2.ItemHeight = 25;
            this.Show2.Location = new System.Drawing.Point(6, 47);
            this.Show2.Name = "Show2";
            this.Show2.Size = new System.Drawing.Size(884, 404);
            this.Show2.TabIndex = 1;
            this.Show2.SelectedIndexChanged += new System.EventHandler(this.Show2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "系辦公告";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clear);
            this.tabPage3.Controls.Add(this.Show3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "自選活動";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(791, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(89, 40);
            this.clear.TabIndex = 1;
            this.clear.Text = "刪除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Show3
            // 
            this.Show3.FormattingEnabled = true;
            this.Show3.ItemHeight = 25;
            this.Show3.Location = new System.Drawing.Point(3, 49);
            this.Show3.Name = "Show3";
            this.Show3.Size = new System.Drawing.Size(887, 404);
            this.Show3.TabIndex = 0;
            // 
            // NCU_MSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "NCU_MSG";
            this.Text = "NCU_MSG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NCU_MSG_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox Show2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button go2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox Show3;
        private System.Windows.Forms.Button add_data;
        private System.Windows.Forms.Button add_data2;
        private System.Windows.Forms.Button clear;
    }
}

