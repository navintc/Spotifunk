using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Spotifunk
{



    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            mainViews.Top = mainViews.Top - mainViews.ItemSize.Height;
            mainViews.Height = mainViews.Height + mainViews.ItemSize.Height;
            mainViews.Region = new Region(new RectangleF(tabPage1.Left, tabPage1.Top, tabPage1.Width, tabPage1.Height + tabControl1.ItemSize.Height));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mainViews.SelectedIndex = 1;
        }

        private void requests_Click(object sender, EventArgs e)
        {
            
            NewFriend newFriendForm = new NewFriend();
            newFriendForm.ShowDialog(); 
        }
    }


    public class friendReqs
    {
        private string _friendLink = string.Empty;

        public void friendReqSet(string form2FriendLink)
        {
        /*https://open.spotify.com/user/gbpym67h3gwlaqeezu6dw7yfa?si=764705ebf52d4789 
         */
            
            _friendLink = form2FriendLink;
            Debug.WriteLine(_friendLink);
        }


    }
}
