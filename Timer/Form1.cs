using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class stopwatch_form : Form
    {
        public stopwatch_form()
        {
            InitializeComponent();
        }

        private string total_time = "";

        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;

        private bool stop = true;

        private bool timer = true;

        private void form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer_setting.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer)
            {
                seconds++;
                label1.Text = get_total_time();
            }
            else
            {
                label1.Text = change_timer_time();
                if(time_progress.Value<time_progress.Maximum)
                {
                    time_progress.Value++;
                }
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            start_btn_actions();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stop_btn_actions();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            reset_btn_actions();
        }

        private void timer_btn_Click(object sender, EventArgs e)
        {
            timer_btn_actions();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            label1.Text = get_total_timer();

            time_progress.Maximum = hours * 3600 + minutes * 60 + seconds;
            time_progress.Minimum = 0;  
        }

        private void start_btn_actions()
        {

            timer1.Enabled = true;
            start_btn.Visible = false;

            timer_btn.Visible = false;

            change_btns.Visible = true;

            timer_setting.Visible = false;

            if(!timer)
            {
                time_progress.Visible = true;


            }
        }

        private void stop_btn_actions()
        {
            if (stop)
            {
                timer1.Enabled = false;
                stop_btn.Text = "Start";
                stop = false;
            }
            else
            {
                timer1.Enabled = true;
                stop_btn.Text = "Stop";
                stop = true;
            }
        }

        private void reset_btn_actions()
        {
            timer1.Enabled = false;

            change_btns.Visible = false;

            seconds = 0;
            hours = 0;
            minutes = 0;
            label1.Text = get_total_time();

            start_btn.Visible = true;

            timer_btn.Visible = true;

            time_progress.Value = 0;
            time_progress.Visible = false;

            if(!timer)
            {
                timer_setting.Visible = true;
                label1.Text = get_total_timer();
            }
        }

        private void timer_btn_actions()
        {
            if (timer)
            {
                timer1.Enabled = false;

                minutes = 0;
                seconds = 0;
                hours = 0;

                second_txt_box.Text = "00";
                minute_txt_box.Text = "00";
                hour_txt_box.Text = "00";

                label1.Text = get_total_timer();

                timer_btn.Text = "Stopwatch";

                timer_setting.Visible = true;

                timer = false;

                label1.Font = new Font(label1.Font.FontFamily, 40);
            }
            else
            {
                timer1.Enabled = false;

                minutes = 0;
                seconds = 0;
                hours = 0;

                label1.Text = get_total_time();

                start_btn.Visible = true;

                timer_btn.Text = "Timer";

                timer_btn.Visible = true;

                timer_setting.Visible = false;

                label1.Font = new Font(label1.Font.FontFamily, 80);

                timer = true;
            }
        }

        private string get_total_time()
        {
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }

            if (hours > 0)
                total_time = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            else if (minutes > 0)
                total_time = $"{minutes:D2}:{seconds:D2}";
            else
                total_time = $"{seconds:D2}";

            return total_time ;
        }

        private string get_total_timer()
        {
            int.TryParse(hour_txt_box.Text, out int h);
            int.TryParse(minute_txt_box.Text,out int m);
            int.TryParse(second_txt_box.Text, out int s);

            if (m > 59) m = 59;
            if (s > 59) s = 59;

            hour_txt_box.Text = h.ToString("D2");
            minute_txt_box.Text = m.ToString("D2");
            second_txt_box.Text = s.ToString("D2");

            hours = h;
            minutes = m;
            seconds = s;

            return $"{h:D2}:{m:D2}:{s:D2}";
        }

        private string change_timer_time()
        {
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                timer1.Enabled = false;
                Console.Beep();
                reset_btn_actions();
                return "00:00:00";
            }

            if (seconds > 0)
            {
                seconds--;
            }
            else
            {
                seconds = 59;
                if (minutes > 0)
                {
                    minutes--;
                }
                else
                {
                    minutes = 59;
                    if (hours > 0)
                    {
                        hours--;
                    }
                }
            }

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void hour_txt_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void minute_txt_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void second_txt_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
