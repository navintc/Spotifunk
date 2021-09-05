
namespace Spotifunk
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.close = new System.Windows.Forms.Button();
            this.titleSpotifunk = new System.Windows.Forms.Label();
            this.requests = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Friends = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.AskOuts = new System.Windows.Forms.TabPage();
            this.mainViews = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Friends.SuspendLayout();
            this.mainViews.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(191, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // titleSpotifunk
            // 
            this.titleSpotifunk.AutoSize = true;
            this.titleSpotifunk.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleSpotifunk.ForeColor = System.Drawing.Color.Green;
            this.titleSpotifunk.Location = new System.Drawing.Point(5, 4);
            this.titleSpotifunk.Name = "titleSpotifunk";
            this.titleSpotifunk.Size = new System.Drawing.Size(114, 28);
            this.titleSpotifunk.TabIndex = 2;
            this.titleSpotifunk.Text = "Spotifunk";
            this.titleSpotifunk.Click += new System.EventHandler(this.label1_Click);
            // 
            // requests
            // 
            this.requests.Image = ((System.Drawing.Image)(resources.GetObject("requests.Image")));
            this.requests.Location = new System.Drawing.Point(162, 9);
            this.requests.Name = "requests";
            this.requests.Size = new System.Drawing.Size(23, 23);
            this.requests.TabIndex = 1;
            this.requests.UseVisualStyleBackColor = true;
            this.requests.Click += new System.EventHandler(this.requests_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Brian",
            "David",
            "Gilbert"});
            this.listBox1.Location = new System.Drawing.Point(2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 344);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Friends);
            this.tabControl1.Controls.Add(this.AskOuts);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(215, 426);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Friends
            // 
            this.Friends.Controls.Add(this.btnSend);
            this.Friends.Controls.Add(this.listBox1);
            this.Friends.Location = new System.Drawing.Point(4, 29);
            this.Friends.Name = "Friends";
            this.Friends.Padding = new System.Windows.Forms.Padding(3);
            this.Friends.Size = new System.Drawing.Size(207, 393);
            this.Friends.TabIndex = 0;
            this.Friends.Text = "Friends";
            this.Friends.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(3, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(201, 30);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // AskOuts
            // 
            this.AskOuts.Location = new System.Drawing.Point(4, 29);
            this.AskOuts.Name = "AskOuts";
            this.AskOuts.Padding = new System.Windows.Forms.Padding(3);
            this.AskOuts.Size = new System.Drawing.Size(207, 393);
            this.AskOuts.TabIndex = 1;
            this.AskOuts.Text = "AskOuts";
            this.AskOuts.UseVisualStyleBackColor = true;
            // 
            // mainViews
            // 
            this.mainViews.Controls.Add(this.tabPage1);
            this.mainViews.Controls.Add(this.tabPage2);
            this.mainViews.Location = new System.Drawing.Point(5, 38);
            this.mainViews.Name = "mainViews";
            this.mainViews.SelectedIndex = 0;
            this.mainViews.Size = new System.Drawing.Size(226, 461);
            this.mainViews.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(218, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(218, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 488);
            this.Controls.Add(this.mainViews);
            this.Controls.Add(this.titleSpotifunk);
            this.Controls.Add(this.requests);
            this.Controls.Add(this.close);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "Spotifunk";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl1.ResumeLayout(false);
            this.Friends.ResumeLayout(false);
            this.mainViews.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label titleSpotifunk;
        private System.Windows.Forms.Button requests;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Friends;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabPage AskOuts;
        private System.Windows.Forms.TabControl mainViews;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

