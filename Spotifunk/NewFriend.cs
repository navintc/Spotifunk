using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spotifunk
{
    public partial class NewFriend : Form
    {
        public NewFriend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            friendReqs newFriend = new friendReqs();
            newFriend.friendReqSet(friendRequestSend.Text);
        }
    }
}
