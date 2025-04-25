using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TimeSpan targetTime;
        private System.Windows.Forms.Timer timer;
        private bool isColorFlipped = false;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(txtTime.Text, out targetTime))
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid time in HH:MM:SS format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Change background color
            this.BackColor = isColorFlipped ? Color.LightBlue : Color.LightGreen;
            isColorFlipped = !isColorFlipped;

            if (currentTime.Hours == targetTime.Hours &&
                currentTime.Minutes == targetTime.Minutes &&
                currentTime.Seconds == targetTime.Seconds)
            {
                timer.Stop();
                this.BackColor = SystemColors.Control; // Reset color
                MessageBox.Show("Alarm ringing! Wake up!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
