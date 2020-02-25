using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryTryTry_
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            Alphabet Form2 = new Alphabet();
            Form2.Show();
            this.Hide();

        }
    }
}
