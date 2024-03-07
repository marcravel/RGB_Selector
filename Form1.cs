using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void txtBlue_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Enter!");
        }       

        private void trackRed_ValueChanged(object sender, EventArgs e)
        {
            txtRed.Text = trackRed.Value.ToString();
            txtGreen.Text = trackGreen.Value.ToString();
            txtBlue.Text = trackBlue.Value.ToString();
            output.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void trackGreen_ValueChanged(object sender, EventArgs e)
        {
            txtRed.Text = trackRed.Value.ToString();
            txtGreen.Text = trackGreen.Value.ToString();
            txtBlue.Text = trackBlue.Value.ToString();
            output.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void trackBlue_ValueChanged(object sender, EventArgs e)
        {
            txtRed.Text = trackRed.Value.ToString();
            txtGreen.Text = trackGreen.Value.ToString();
            txtBlue.Text = trackBlue.Value.ToString();
            output.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void txtRed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(txtRed.Text) <= 255 && int.Parse(txtRed.Text) >= 0)
                {
                    trackRed.Value = int.Parse(txtRed.Text);
                }
                else
                {
                    MessageBox.Show("Enter a value less than 255", "Valur error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtGreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(txtGreen.Text) <= 255 && int.Parse(txtGreen.Text) >= 0)
                {
                    trackGreen.Value = int.Parse(txtGreen.Text);
                }
                else
                {
                    MessageBox.Show("Enter a value less than 255", "Valur error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBlue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(txtBlue.Text) <= 255 && int.Parse(txtBlue.Text) >= 0)
                {
                    trackBlue.Value = int.Parse(txtBlue.Text);
                }
                else
                {
                    MessageBox.Show("Enter a value less than 255", "Valur error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var closingWindow = new ClosignForm();
            DialogResult result = closingWindow.ShowDialog();  
            if (result == DialogResult.Cancel || result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
