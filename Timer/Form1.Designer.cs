namespace Timer
{
    partial class stopwatch_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stopwatch_form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.change_btns = new System.Windows.Forms.TableLayoutPanel();
            this.timer_btn = new System.Windows.Forms.Button();
            this.hour_txt_box = new System.Windows.Forms.TextBox();
            this.timer_setting = new System.Windows.Forms.FlowLayoutPanel();
            this.hours_txt_label = new System.Windows.Forms.Label();
            this.minutes_txt_label = new System.Windows.Forms.Label();
            this.minute_txt_box = new System.Windows.Forms.TextBox();
            this.second_txt_label = new System.Windows.Forms.Label();
            this.second_txt_box = new System.Windows.Forms.TextBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.time_progress = new System.Windows.Forms.ProgressBar();
            this.change_btns.SuspendLayout();
            this.timer_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 555);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_btn
            // 
            this.start_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(0, 492);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(726, 63);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.AutoSize = true;
            this.stop_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(4, 5);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(355, 52);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(367, 5);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(355, 52);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // change_btns
            // 
            this.change_btns.ColumnCount = 2;
            this.change_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.change_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.change_btns.Controls.Add(this.stop_btn, 0, 0);
            this.change_btns.Controls.Add(this.reset_btn, 1, 0);
            this.change_btns.Cursor = System.Windows.Forms.Cursors.Default;
            this.change_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.change_btns.Location = new System.Drawing.Point(0, 430);
            this.change_btns.Margin = new System.Windows.Forms.Padding(0);
            this.change_btns.Name = "change_btns";
            this.change_btns.RowCount = 1;
            this.change_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.change_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.change_btns.Size = new System.Drawing.Size(726, 62);
            this.change_btns.TabIndex = 4;
            this.change_btns.Visible = false;
            // 
            // timer_btn
            // 
            this.timer_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.timer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_btn.Location = new System.Drawing.Point(0, 0);
            this.timer_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timer_btn.Name = "timer_btn";
            this.timer_btn.Size = new System.Drawing.Size(726, 63);
            this.timer_btn.TabIndex = 5;
            this.timer_btn.Text = "Timer";
            this.timer_btn.UseVisualStyleBackColor = true;
            this.timer_btn.Click += new System.EventHandler(this.timer_btn_Click);
            // 
            // hour_txt_box
            // 
            this.hour_txt_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hour_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_txt_box.Location = new System.Drawing.Point(105, 3);
            this.hour_txt_box.MaxLength = 2;
            this.hour_txt_box.Name = "hour_txt_box";
            this.hour_txt_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hour_txt_box.Size = new System.Drawing.Size(70, 39);
            this.hour_txt_box.TabIndex = 6;
            this.hour_txt_box.Text = "00";
            this.hour_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hour_txt_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_txt_box_KeyPress);
            // 
            // timer_setting
            // 
            this.timer_setting.AutoSize = true;
            this.timer_setting.Controls.Add(this.hours_txt_label);
            this.timer_setting.Controls.Add(this.hour_txt_box);
            this.timer_setting.Controls.Add(this.minutes_txt_label);
            this.timer_setting.Controls.Add(this.minute_txt_box);
            this.timer_setting.Controls.Add(this.second_txt_label);
            this.timer_setting.Controls.Add(this.second_txt_box);
            this.timer_setting.Controls.Add(this.done_btn);
            this.timer_setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timer_setting.Location = new System.Drawing.Point(0, 385);
            this.timer_setting.Margin = new System.Windows.Forms.Padding(0);
            this.timer_setting.Name = "timer_setting";
            this.timer_setting.Size = new System.Drawing.Size(726, 45);
            this.timer_setting.TabIndex = 7;
            // 
            // hours_txt_label
            // 
            this.hours_txt_label.AutoSize = true;
            this.hours_txt_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hours_txt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_txt_label.Location = new System.Drawing.Point(3, 8);
            this.hours_txt_label.Name = "hours_txt_label";
            this.hours_txt_label.Size = new System.Drawing.Size(96, 37);
            this.hours_txt_label.TabIndex = 7;
            this.hours_txt_label.Text = "Hour:";
            // 
            // minutes_txt_label
            // 
            this.minutes_txt_label.AutoSize = true;
            this.minutes_txt_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.minutes_txt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_txt_label.Location = new System.Drawing.Point(181, 8);
            this.minutes_txt_label.Name = "minutes_txt_label";
            this.minutes_txt_label.Size = new System.Drawing.Size(121, 37);
            this.minutes_txt_label.TabIndex = 8;
            this.minutes_txt_label.Text = "Minute:";
            // 
            // minute_txt_box
            // 
            this.minute_txt_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.minute_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute_txt_box.Location = new System.Drawing.Point(308, 3);
            this.minute_txt_box.MaxLength = 2;
            this.minute_txt_box.Name = "minute_txt_box";
            this.minute_txt_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minute_txt_box.Size = new System.Drawing.Size(70, 39);
            this.minute_txt_box.TabIndex = 9;
            this.minute_txt_box.Text = "00";
            this.minute_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minute_txt_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minute_txt_box_KeyPress);
            // 
            // second_txt_label
            // 
            this.second_txt_label.AutoSize = true;
            this.second_txt_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.second_txt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_txt_label.Location = new System.Drawing.Point(384, 8);
            this.second_txt_label.Name = "second_txt_label";
            this.second_txt_label.Size = new System.Drawing.Size(134, 37);
            this.second_txt_label.TabIndex = 10;
            this.second_txt_label.Text = "Second:";
            // 
            // second_txt_box
            // 
            this.second_txt_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.second_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_txt_box.Location = new System.Drawing.Point(524, 3);
            this.second_txt_box.MaxLength = 2;
            this.second_txt_box.Name = "second_txt_box";
            this.second_txt_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.second_txt_box.Size = new System.Drawing.Size(70, 39);
            this.second_txt_box.TabIndex = 11;
            this.second_txt_box.Text = "00";
            this.second_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second_txt_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_txt_box_KeyPress);
            // 
            // done_btn
            // 
            this.done_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.done_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.Location = new System.Drawing.Point(600, 3);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(92, 39);
            this.done_btn.TabIndex = 12;
            this.done_btn.Text = "Ok";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // time_progress
            // 
            this.time_progress.Dock = System.Windows.Forms.DockStyle.Top;
            this.time_progress.Location = new System.Drawing.Point(0, 63);
            this.time_progress.Name = "time_progress";
            this.time_progress.Size = new System.Drawing.Size(726, 28);
            this.time_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.time_progress.TabIndex = 8;
            this.time_progress.Visible = false;
            // 
            // stopwatch_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 555);
            this.Controls.Add(this.time_progress);
            this.Controls.Add(this.timer_setting);
            this.Controls.Add(this.timer_btn);
            this.Controls.Add(this.change_btns);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "stopwatch_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer & Stopwatch";
            this.Load += new System.EventHandler(this.form_Load);
            this.change_btns.ResumeLayout(false);
            this.change_btns.PerformLayout();
            this.timer_setting.ResumeLayout(false);
            this.timer_setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.TableLayoutPanel change_btns;
        private System.Windows.Forms.Button timer_btn;
        private System.Windows.Forms.TextBox hour_txt_box;
        private System.Windows.Forms.FlowLayoutPanel timer_setting;
        private System.Windows.Forms.Label hours_txt_label;
        private System.Windows.Forms.Label minutes_txt_label;
        private System.Windows.Forms.TextBox minute_txt_box;
        private System.Windows.Forms.Label second_txt_label;
        private System.Windows.Forms.TextBox second_txt_box;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.ProgressBar time_progress;
    }
}

