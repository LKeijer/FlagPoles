using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalismTraining
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            WelcomeText.Text = "Welcome to Nationalism training";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PracticeForm = new Practice();
            PracticeForm.Show();
        }
    }
}
