
namespace Spotifunk_2
{
    partial class mainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainViews = new System.Windows.Forms.TabControl();
            this.mainScreenTab = new System.Windows.Forms.TabPage();
            this.friendReqs = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.friends = new System.Windows.Forms.TabPage();
            this.friendsChat = new System.Windows.Forms.TabPage();
            this.mainViews.SuspendLayout();
            this.mainScreenTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainViews
            // 
            this.mainViews.Controls.Add(this.mainScreenTab);
            this.mainViews.Controls.Add(this.friendReqs);
            this.mainViews.Location = new System.Drawing.Point(2, 28);
            this.mainViews.Name = "mainViews";
            this.mainViews.SelectedIndex = 0;
            this.mainViews.Size = new System.Drawing.Size(231, 453);
            this.mainViews.TabIndex = 0;
            // 
            // mainScreenTab
            // 
            this.mainScreenTab.Controls.Add(this.tabControl1);
            this.mainScreenTab.Location = new System.Drawing.Point(4, 25);
            this.mainScreenTab.Name = "mainScreenTab";
            this.mainScreenTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainScreenTab.Size = new System.Drawing.Size(223, 424);
            this.mainScreenTab.TabIndex = 0;
            this.mainScreenTab.Text = "mainScreenTab";
            this.mainScreenTab.UseVisualStyleBackColor = true;
            // 
            // friendReqs
            // 
            this.friendReqs.Location = new System.Drawing.Point(4, 25);
            this.friendReqs.Name = "friendReqs";
            this.friendReqs.Padding = new System.Windows.Forms.Padding(3);
            this.friendReqs.Size = new System.Drawing.Size(223, 424);
            this.friendReqs.TabIndex = 1;
            this.friendReqs.Text = "friendReqs";
            this.friendReqs.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.friends);
            this.tabControl1.Controls.Add(this.friendsChat);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(223, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // friends
            // 
            this.friends.Location = new System.Drawing.Point(4, 25);
            this.friends.Name = "friends";
            this.friends.Padding = new System.Windows.Forms.Padding(3);
            this.friends.Size = new System.Drawing.Size(206, 389);
            this.friends.TabIndex = 0;
            this.friends.Text = "friends";
            this.friends.UseVisualStyleBackColor = true;
            // 
            // friendsChat
            // 
            this.friendsChat.Location = new System.Drawing.Point(4, 25);
            this.friendsChat.Name = "friendsChat";
            this.friendsChat.Padding = new System.Windows.Forms.Padding(3);
            this.friendsChat.Size = new System.Drawing.Size(215, 395);
            this.friendsChat.TabIndex = 1;
            this.friendsChat.Text = "friendsChat";
            this.friendsChat.UseVisualStyleBackColor = true;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 493);
            this.Controls.Add(this.mainViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainScreen";
            this.Text = "Spotifunk";
            this.Load += new System.EventHandler(this.mainScreen_Load);
            this.mainViews.ResumeLayout(false);
            this.mainScreenTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainViews;
        private System.Windows.Forms.TabPage mainScreenTab;
        private System.Windows.Forms.TabPage friendReqs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage friends;
        private System.Windows.Forms.TabPage friendsChat;
    }
}