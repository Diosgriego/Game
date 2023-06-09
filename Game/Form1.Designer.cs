namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backGround = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.Left = new System.Windows.Forms.Timer(this.components);
            this.Right = new System.Windows.Forms.Timer(this.components);
            this.Up = new System.Windows.Forms.Timer(this.components);
            this.Down = new System.Windows.Forms.Timer(this.components);
            this.BulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.oppTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.Enabled = true;
            this.backGround.Interval = 10;
            this.backGround.Tick += new System.EventHandler(this.backGround_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::Game.Properties.Resources.PlayerStay;
            this.mainPlayer.Location = new System.Drawing.Point(24, 367);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(184, 261);
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // Left
            // 
            this.Left.Interval = 10;
            this.Left.Tick += new System.EventHandler(this.Left_Tick);
            // 
            // Right
            // 
            this.Right.Interval = 10;
            this.Right.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // Up
            // 
            this.Up.Interval = 10;
            this.Up.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // Down
            // 
            this.Down.Interval = 10;
            this.Down.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // BulletsTimer
            // 
            this.BulletsTimer.Enabled = true;
            this.BulletsTimer.Interval = 10;
            this.BulletsTimer.Tick += new System.EventHandler(this.BulletsTimer_Tick);
            // 
            // oppTimer
            // 
            this.oppTimer.Enabled = true;
            this.oppTimer.Interval = 10;
            this.oppTimer.Tick += new System.EventHandler(this.oppTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(849, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 63);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Algerian", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelScore.Location = new System.Drawing.Point(225, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(95, 63);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "00";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Algerian", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelLevel.Location = new System.Drawing.Point(225, 72);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(96, 63);
            this.labelLevel.TabIndex = 5;
            this.labelLevel.Text = "01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources._1644918766_4_phonoteka_org_p_kosmicheskii_fon_dlya_igri_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPlayer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer backGround;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer Left;
        private System.Windows.Forms.Timer Right;
        private System.Windows.Forms.Timer Up;
        private System.Windows.Forms.Timer Down;
        private System.Windows.Forms.Timer BulletsTimer;
        private System.Windows.Forms.Timer oppTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLevel;
    }
}

