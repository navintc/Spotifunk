using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spotifunk_2
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {

            // this will remove the top of tabs. So they could be controled automatically
            mainViews.Top = mainViews.Top - mainViews.ItemSize.Height;
            mainViews.Height = mainViews.Height + mainViews.ItemSize.Height;
            mainViews.Region = new Region(new RectangleF(mainScreenTab.Left, mainScreenTab.Top, mainScreenTab.Width, mainScreenTab.Height + mainViews.ItemSize.Height));
        }
    }
}
