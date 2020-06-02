using System;
using System.Windows.Forms;

namespace Stopwatch

{    
    public partial class Form1 : Form
    {
        private TimeCounter counter;

        public Form1()
        {
            InitializeComponent();
            counter = new TimeCounter(lbWorkTime, lbRestTime);
        }

        #region Button Clicks
        // Start work time counter, stop rest time counter
        private void btnStart_Click(object sender, EventArgs e)
        {
            counter.Start();
        }
        // Stop the work time counter, start rest time counter
        private void btnStop_Click(object sender, EventArgs e)
        {
            counter.Stop();
        }
        // Reset counter and put it into idle mode
        private void btnReset_Click(object sender, EventArgs e)
        {
            counter.Reset(CounterResetType.FullStop);
        }
        // Reset only rest time label
        private void btnResetRest_Click(object sender, EventArgs e)
        {
            counter.Reset(CounterResetType.ResetRest);
        }
        // Open the program's GitHub page
        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khud0/Stopwatch");
        }
        #endregion        
    }
}
