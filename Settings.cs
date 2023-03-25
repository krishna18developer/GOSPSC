using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOSPSC
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Set_btn_Click(object sender, EventArgs e)
        {
            string user_given_process = process_box.Text;
            int user_given_duration =  Int32.Parse(duration_box.Text);
            GOSPSC.Properties.Settings.Default.processName = user_given_process;
            GOSPSC.Properties.Settings.Default.duration = user_given_duration;

            GOSPSC.Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            process_box.Text = GOSPSC.Properties.Settings.Default.processName;
            duration_box.Text = "" + GOSPSC.Properties.Settings.Default.duration;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
