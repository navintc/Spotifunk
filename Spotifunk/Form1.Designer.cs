
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
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Brian",
            "David",
            "Gilbert"});
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 364);
            this.listBox1.TabIndex = 3;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 482);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.titleSpotifunk);
            this.Controls.Add(this.requests);
            this.Controls.Add(this.close);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "Spotifunk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label titleSpotifunk;
        private System.Windows.Forms.Button requests;
        private System.Windows.Forms.ListBox listBox1;
    }
}

