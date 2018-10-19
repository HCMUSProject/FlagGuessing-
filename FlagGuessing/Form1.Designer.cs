namespace FlagGuessing
{
    partial class Main
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
            this.PanelControl = new System.Windows.Forms.Panel();
            this.PanelGamePlay = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.grbQuestion = new System.Windows.Forms.GroupBox();
            this.lb_times = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.lb_score = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lb_Player = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.grbCustom = new System.Windows.Forms.GroupBox();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.PanelControl.SuspendLayout();
            this.PanelGamePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbQuestion.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.grbTime.SuspendLayout();
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
            this.PanelControl.Size = new System.Drawing.Size(344, 579);
            this.PanelControl.TabIndex = 1;
            // 
            // PanelGamePlay
            // 
            this.PanelGamePlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGamePlay.Controls.Add(this.grbQuestion);
            this.PanelGamePlay.Controls.Add(this.btnChoose2);
            this.PanelGamePlay.Controls.Add(this.btnChoose1);
            this.PanelGamePlay.Controls.Add(this.pictureBox2);
            this.PanelGamePlay.Controls.Add(this.pictureBox1);
            this.PanelGamePlay.Location = new System.Drawing.Point(0, 88);
            this.PanelGamePlay.Name = "PanelGamePlay";
            this.PanelGamePlay.Size = new System.Drawing.Size(618, 579);
            this.PanelGamePlay.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(319, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 217);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(96, 472);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(140, 44);
            this.btnChoose1.TabIndex = 1;
            this.btnChoose1.Text = "Chọn";
            this.btnChoose1.UseVisualStyleBackColor = true;
            // 
            // btnChoose2
            // 
            this.btnChoose2.Location = new System.Drawing.Point(373, 472);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(140, 44);
            this.btnChoose2.TabIndex = 1;
            this.btnChoose2.Text = "Chọn";
            this.btnChoose2.UseVisualStyleBackColor = true;
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
            // lb_times
            // 
            this.lb_times.AutoSize = true;
            this.lb_times.Location = new System.Drawing.Point(27, 51);
            this.lb_times.Name = "lb_times";
            this.lb_times.Size = new System.Drawing.Size(49, 20);
            this.lb_times.TabIndex = 0;
            this.lb_times.Text = "Lượt :";
            // 
            // txtTimes
            // 
            this.txtTimes.Enabled = false;
            this.txtTimes.Location = new System.Drawing.Point(127, 48);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.ReadOnly = true;
            this.txtTimes.Size = new System.Drawing.Size(126, 26);
            this.txtTimes.TabIndex = 1;
            this.txtTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Location = new System.Drawing.Point(27, 97);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(75, 20);
            this.lb_score.TabIndex = 0;
            this.lb_score.Text = "Điểm số :";
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(127, 94);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(126, 26);
            this.txtScore.TabIndex = 1;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lb_Player
            // 
            this.lb_Player.AutoSize = true;
            this.lb_Player.Location = new System.Drawing.Point(27, 143);
            this.lb_Player.Name = "lb_Player";
            this.lb_Player.Size = new System.Drawing.Size(83, 20);
            this.lb_Player.TabIndex = 0;
            this.lb_Player.Text = "Người chơi";
            // 
            // txtPlayer
            // 
            this.txtPlayer.Enabled = false;
            this.txtPlayer.Location = new System.Drawing.Point(127, 140);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.ReadOnly = true;
            this.txtPlayer.Size = new System.Drawing.Size(126, 26);
            this.txtPlayer.TabIndex = 1;
            this.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.Location = new System.Drawing.Point(66, 44);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(57, 40);
            this.lbMinutes.TabIndex = 0;
            this.lbMinutes.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.Location = new System.Drawing.Point(162, 44);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(57, 40);
            this.lbSeconds.TabIndex = 0;
            this.lbSeconds.Text = "00";
            // 
            // grbCustom
            // 
            this.grbCustom.Location = new System.Drawing.Point(23, 404);
            this.grbCustom.Name = "grbCustom";
            this.grbCustom.Size = new System.Drawing.Size(288, 139);
            this.grbCustom.TabIndex = 4;
            this.grbCustom.TabStop = false;
            this.grbCustom.Text = "Tuỳ chỉnh";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(17, 34);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(81, 30);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 661);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelGamePlay);
            this.Name = "Main";
            this.Text = "Flags Guessing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelControl.ResumeLayout(false);
            this.PanelGamePlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbQuestion.ResumeLayout(false);
            this.grbQuestion.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
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
    }
}

