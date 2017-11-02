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
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void Practice_Load(object sender, EventArgs e)
        {
            PracticeTest.Text = "What would you like to practice?";
        }

        private void PracticeTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Test the selected continent")
            {
                this.Hide();
                var Practicing = new Practicing();
                Practicing.Show();
            }
            else
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();
                PracticeTest.Text = selectedItem;
                button1.Text = "Test the selected continent";
                foreach (object item in listBox1.Items)
                {
                    sb.Append(item.ToString());
                    sb.Append(" ");
                }
            }
        }
    }
}
