using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spotifunk_2
{
    public partial class mainScreen : Form
    {

        public string userId;
        public mainScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            // this will scrape a better username from the link givn in the txt file
            // for the user and will be stored in variable
            StreamReader userProfileLink = new StreamReader("C:\\Users\\Navin 5\\Desktop\\Fuck Files\\userProfileLink.txt");
            userId = userProfileLink.ReadLine();
            userId = userId.Replace("https://open.spotify.com/user/", "");
            userId = userId.Substring(0, userId.LastIndexOf("?"));
            System.Diagnostics.Debug.WriteLine(userId);

            lbl_welcome.Text = ("Hello, " + userId);


            // this will remove the top of tabs. So they could be controled automatically
            mainViews.Top = mainViews.Top - mainViews.ItemSize.Height;
            mainViews.Height = mainViews.Height + mainViews.ItemSize.Height;
            mainViews.Region = new Region(new RectangleF(mainScreenTab.Left, mainScreenTab.Top, mainScreenTab.Width, mainScreenTab.Height + mainViews.ItemSize.Height));
        }
    }
}
