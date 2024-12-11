using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karatavas
{
    public partial class Form3 : Form
    {
        public Form3(string NejausaisVards)
        {
            InitializeComponent();
            label2.Text = "Vārds bija " + NejausaisVards + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
