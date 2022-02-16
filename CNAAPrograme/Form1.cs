using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNAAPrograme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new LearningPosibilities().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var window = new CCNAForms(1);
            window.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var window = new CCNAForms(2);
            window.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var window = new CCNAForms(3);
            window.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
