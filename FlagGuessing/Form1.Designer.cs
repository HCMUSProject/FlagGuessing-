namespace FlagGuessing
{
    partial class MainForm
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
            this.PanelControl = new System.Windows.Forms.Panel();
            this.grbCustom = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lb_Player = new System.Windows.Forms.Label();
            this.lb_times = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.PanelGamePlay = new System.Windows.Forms.Panel();
            this.lb_notification = new System.Windows.Forms.Label();
            this.grbQuestion = new System.Windows.Forms.GroupBox();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.PanelControl.SuspendLayout();
            this.grbCustom.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.PanelGamePlay.SuspendLayout();
            this.grbQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl
            // 
            this.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControl.Controls.Add(this.grbCustom);
            this.PanelControl.Controls.Add(this.grbTime);
            this.PanelControl.Controls.Add(this.grbInfo);
            this.PanelControl.Location = new System.Drawing.Point(615, 88);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(344, 650);
            this.PanelControl.TabIndex = 0;
            // 
            // grbCustom
            // 
            this.grbCustom.Controls.Add(this.btnRestart);
            this.grbCustom.Controls.Add(this.btnStart);
            this.grbCustom.Location = new System.Drawing.Point(23, 404);
            this.grbCustom.Name = "grbCustom";
            this.grbCustom.Size = new System.Drawing.Size(288, 196);
            this.grbCustom.TabIndex = 0;
            this.grbCustom.TabStop = false;
            this.grbCustom.Text = "Tuỳ chỉnh";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(151, 35);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(114, 44);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Chơi lại";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.lbSeconds);
            this.grbTime.Controls.Add(this.label2);
            this.grbTime.Controls.Add(this.lbMinutes);
            this.grbTime.Location = new System.Drawing.Point(23, 18);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(288, 132);
            this.grbTime.TabIndex = 3;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Thời gian";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Font = new System.Drawing.Font("DS-Digital", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.ForeColor = System.Drawing.Color.Red;
            this.lbSeconds.Location = new System.Drawing.Point(171, 44);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(82, 56);
            this.lbSeconds.TabIndex = 0;
            this.lbSeconds.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(132, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("DS-Digital", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.ForeColor = System.Drawing.Color.Red;
            this.lbMinutes.Location = new System.Drawing.Point(44, 44);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(82, 56);
            this.lbMinutes.TabIndex = 0;
            this.lbMinutes.Text = "00";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.txtTimes);
            this.grbInfo.Controls.Add(this.txtPlayer);
            this.grbInfo.Controls.Add(this.txtScore);
            this.grbInfo.Controls.Add(this.lb_Player);
            this.grbInfo.Controls.Add(this.lb_times);
            this.grbInfo.Controls.Add(this.lb_score);
            this.grbInfo.Location = new System.Drawing.Point(23, 163);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(288, 217);
            this.grbInfo.TabIndex = 2;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin";
            // 
            // txtTimes
            // 
            this.txtTimes.Enabled = false;
            this.txtTimes.Location = new System.Drawing.Point(127, 48);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.ReadOnly = true;
            this.txtTimes.Size = new System.Drawing.Size(126, 26);
            this.txtTimes.TabIndex = 3;
            this.txtTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer
            // 
            this.txtPlayer.Enabled = false;
            this.txtPlayer.Location = new System.Drawing.Point(127, 140);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.ReadOnly = true;
            this.txtPlayer.Size = new System.Drawing.Size(126, 26);
            this.txtPlayer.TabIndex = 3;
            this.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(127, 94);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(126, 26);
            this.txtScore.TabIndex = 3;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Player
            // 
            this.lb_Player.AutoSize = true;
            this.lb_Player.Location = new System.Drawing.Point(27, 143);
            this.lb_Player.Name = "lb_Player";
            this.lb_Player.Size = new System.Drawing.Size(83, 20);
            this.lb_Player.TabIndex = 3;
            this.lb_Player.Text = "Người chơi";
            // 
            // lb_times
            // 
            this.lb_times.AutoSize = true;
            this.lb_times.Location = new System.Drawing.Point(27, 51);
            this.lb_times.Name = "lb_times";
            this.lb_times.Size = new System.Drawing.Size(49, 20);
            this.lb_times.TabIndex = 3;
            this.lb_times.Text = "Lượt :";
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Location = new System.Drawing.Point(27, 97);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(75, 20);
            this.lb_score.TabIndex = 3;
            this.lb_score.Text = "Điểm số :";
            // 
            // PanelGamePlay
            // 
            this.PanelGamePlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGamePlay.Controls.Add(this.lb_notification);
            this.PanelGamePlay.Controls.Add(this.grbQuestion);
            this.PanelGamePlay.Controls.Add(this.btnChoose2);
            this.PanelGamePlay.Controls.Add(this.btnChoose1);
            this.PanelGamePlay.Controls.Add(this.pictureBox2);
            this.PanelGamePlay.Controls.Add(this.pictureBox1);
            this.PanelGamePlay.Location = new System.Drawing.Point(0, 88);
            this.PanelGamePlay.Name = "PanelGamePlay";
            this.PanelGamePlay.Size = new System.Drawing.Size(618, 650);
            this.PanelGamePlay.TabIndex = 1;
            // 
            // lb_notification
            // 
            this.lb_notification.AutoSize = true;
            this.lb_notification.ForeColor = System.Drawing.Color.Red;
            this.lb_notification.Location = new System.Drawing.Point(160, 548);
            this.lb_notification.Name = "lb_notification";
            this.lb_notification.Size = new System.Drawing.Size(0, 20);
            this.lb_notification.TabIndex = 3;
            // 
            // grbQuestion
            // 
            this.grbQuestion.Controls.Add(this.lbQuestion);
            this.grbQuestion.Location = new System.Drawing.Point(24, 18);
            this.grbQuestion.Name = "grbQuestion";
            this.grbQuestion.Size = new System.Drawing.Size(570, 152);
            this.grbQuestion.TabIndex = 2;
            this.grbQuestion.TabStop = false;
            this.grbQuestion.Text = "Câu hỏi:";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(17, 34);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(0, 30);
            this.lbQuestion.TabIndex = 1;
            // 
            // btnChoose2
            // 
            this.btnChoose2.Location = new System.Drawing.Point(373, 472);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(140, 44);
            this.btnChoose2.TabIndex = 2;
            this.btnChoose2.Text = "Chọn";
            this.btnChoose2.UseVisualStyleBackColor = true;
            this.btnChoose2.Click += new System.EventHandler(this.btnChoose2_Click);
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(96, 472);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(140, 44);
            this.btnChoose1.TabIndex = 2;
            this.btnChoose1.Text = "Chọn";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(319, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(24, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(207, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(508, 54);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "TRÒ CHƠI ĐOÁN QUỐC KỲ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 708);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelGamePlay);
            this.Name = "MainForm";
            this.Text = "Flags Guessing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelControl.ResumeLayout(false);
            this.grbCustom.ResumeLayout(false);
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.PanelGamePlay.ResumeLayout(false);
            this.PanelGamePlay.PerformLayout();
            this.grbQuestion.ResumeLayout(false);
            this.grbQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Panel PanelGamePlay;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnChoose2;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.Label lb_times;
        private System.Windows.Forms.GroupBox grbQuestion;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label lb_Player;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.GroupBox grbCustom;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label lb_notification;
    }
}

