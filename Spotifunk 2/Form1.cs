using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Spotifunk_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // skipping if a txt with user's spotify link exists
            if (File.Exists("C:\\Users\\Navin 5\\Desktop\\Fuck Files\\userProfileLink.txt"))
            {
                System.Diagnostics.Debug.WriteLine("File Exits");
                mainScreen newMainScreen = new mainScreen();
                newMainScreen.ShowDialog();
                this.Close();
            }
            else {

                // System.Diagnostics.Debug.WriteLine is used intead of of including the whole library
                // to minimize toil when removing Debug Logs
                System.Diagnostics.Debug.WriteLine("Nane mahaththaya");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating a text file to save user's spotify link
            TextWriter userProfileLink = new StreamWriter("C:\\Users\\Navin 5\\Desktop\\Fuck Files\\userProfileLink.txt");
            userProfileLink.Write(textBox1.Text);
            userProfileLink.Close();
        }
    }
}
