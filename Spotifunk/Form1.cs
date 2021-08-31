using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotifunk
{
    public partial class main : Form
    {
        //-----------------------------------------------------------------------------------------------
        private bool mouseDown;
        private Point lastLocation;

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            Debug.Log(mouseDown);
            lastLocation = e.Location;
        }

        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //-----------------------------------------------------------------------------------------------






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
    }
}
