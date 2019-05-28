using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeButton
{
    public partial class formGame : Form
    {
        public long hopeTotal = 0;

        public formGame()
        {
            InitializeComponent();
            progTime.Value = 50;
        }

        private void btnHope_Click(object sender, EventArgs e)
        {
            progTime.Value -= 10;
            hopeTotal++;

            if (progTime.Value <= 0)
            {
                timeProg.Enabled = false;
                MessageBox.Show("You're going too fast!");
                System.Windows.Forms.Application.Exit();
            }
            else if (hopeTotal == 10)
            {
                lstbxLog.Items.Add("Ten Hope items created.");
            }
        }

        private void timeProg_Tick(object sender, EventArgs e)
        {
            progTime.Value += 10;

            if (progTime.Value >= 100)
            {
                timeProg.Enabled = false;
                MessageBox.Show("You're going too slow!");
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}