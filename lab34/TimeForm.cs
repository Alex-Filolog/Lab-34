using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab34
{
    public partial class TimeForm : Form
    {
        public TimeForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TimeUpdateTimer.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            TimeUpdateTimer.Stop();
        }

        private int seconds = 0;

        private void TimeUpdateTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            TimeLabel.Text = string.Format("{0:D2}:{1:D2}", seconds / 60, seconds % 60);
        }
    }
}