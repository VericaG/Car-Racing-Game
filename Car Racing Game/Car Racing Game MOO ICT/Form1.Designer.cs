namespace Car_Racing_Game_MOO_ICT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fuelCanister = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.carSelectionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.shieldCountLabel = new System.Windows.Forms.Label();
            this.labelaStit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelCanister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.fuelCanister);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 639);
            this.panel1.TabIndex = 0;
            // 
            // fuelCanister
            // 
            this.fuelCanister.BackColor = System.Drawing.Color.Black;
            this.fuelCanister.BackgroundImage = global::Car_Racing_Game_MOO_ICT.Properties.Resources.fuel;
            this.fuelCanister.Enabled = false;
            this.fuelCanister.Location = new System.Drawing.Point(436, 375);
            this.fuelCanister.Name = "fuelCanister";
            this.fuelCanister.Size = new System.Drawing.Size(52, 52);
            this.fuelCanister.TabIndex = 6;
            this.fuelCanister.TabStop = false;
            this.fuelCanister.Click += new System.EventHandler(this.fuelCanister_Click);
            // 
            // AI2
            // 
            this.AI2.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(563, 76);
            this.AI2.Margin = new System.Windows.Forms.Padding(4);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 5;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // AI1
            // 
            this.AI1.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(101, 76);
            this.AI1.Margin = new System.Windows.Forms.Padding(4);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // award
            // 
            this.award.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(238, 281);
            this.award.Margin = new System.Windows.Forms.Padding(4);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(152, 187);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            this.award.Visible = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(101, 462);
            this.explosion.Margin = new System.Windows.Forms.Padding(4);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            this.explosion.Visible = false;
            // 
            // player
            // 
            this.player.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(287, 495);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Margin = new System.Windows.Forms.Padding(4);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(633, 639);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 4;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -639);
            this.roadTrack1.Margin = new System.Windows.Forms.Padding(4);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(633, 639);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(864, 468);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(704, 396);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(457, 46);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Резултат: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 231);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // carSelectionCombo
            // 
            this.carSelectionCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carSelectionCombo.ForeColor = System.Drawing.Color.Black;
            this.carSelectionCombo.FormattingEnabled = true;
            this.carSelectionCombo.Location = new System.Drawing.Point(847, 585);
            this.carSelectionCombo.Name = "carSelectionCombo";
            this.carSelectionCombo.Size = new System.Drawing.Size(208, 24);
            this.carSelectionCombo.TabIndex = 4;
            this.carSelectionCombo.SelectedIndexChanged += new System.EventHandler(this.carSelectionCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(768, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изберете го вашиот автомобил";
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fuelLabel.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.ForeColor = System.Drawing.Color.Crimson;
            this.fuelLabel.Location = new System.Drawing.Point(707, 299);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(198, 68);
            this.fuelLabel.TabIndex = 7;
            this.fuelLabel.Text = "Гориво: 1000\r\n\r\n";
            this.fuelLabel.Click += new System.EventHandler(this.fuelLabel_Click);
            // 
            // shieldCountLabel
            // 
            this.shieldCountLabel.AutoSize = true;
            this.shieldCountLabel.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.shieldCountLabel.ForeColor = System.Drawing.Color.Crimson;
            this.shieldCountLabel.Location = new System.Drawing.Point(971, 299);
            this.shieldCountLabel.Name = "shieldCountLabel";
            this.shieldCountLabel.Size = new System.Drawing.Size(169, 34);
            this.shieldCountLabel.TabIndex = 8;
            this.shieldCountLabel.Text = "Штитови: 3";
            // 
            // labelaStit
            // 
            this.labelaStit.AutoSize = true;
            this.labelaStit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaStit.Location = new System.Drawing.Point(986, 351);
            this.labelaStit.Name = "labelaStit";
            this.labelaStit.Size = new System.Drawing.Size(0, 16);
            this.labelaStit.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1209, 661);
            this.Controls.Add(this.labelaStit);
            this.Controls.Add(this.shieldCountLabel);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carSelectionCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing Game ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelCanister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ComboBox carSelectionCombo;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fuelCanister;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.Label shieldCountLabel;
        private System.Windows.Forms.Label labelaStit;
    }
}

