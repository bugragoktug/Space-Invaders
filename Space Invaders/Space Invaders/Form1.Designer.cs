namespace Space_Invaders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            spaceship = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ufo = new PictureBox();
            alien = new PictureBox();
            stars1 = new PictureBox();
            stars2 = new PictureBox();
            scoreValue = new Label();
            alien2 = new PictureBox();
            alien3 = new PictureBox();
            alien4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)spaceship).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ufo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stars1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stars2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // spaceship
            // 
            spaceship.BackColor = Color.Transparent;
            spaceship.Image = (Image)resources.GetObject("spaceship.Image");
            spaceship.Location = new Point(190, 371);
            spaceship.Name = "spaceship";
            spaceship.Size = new Size(70, 53);
            spaceship.SizeMode = PictureBoxSizeMode.Zoom;
            spaceship.TabIndex = 0;
            spaceship.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // ufo
            // 
            ufo.BackColor = Color.Transparent;
            ufo.Image = (Image)resources.GetObject("ufo.Image");
            ufo.Location = new Point(183, 69);
            ufo.Name = "ufo";
            ufo.Size = new Size(77, 67);
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.TabIndex = 1;
            ufo.TabStop = false;
            ufo.Tag = "enemy";
//            ufo.Click += ufo_Click;
            // 
            // alien
            // 
            alien.BackColor = Color.Transparent;
            alien.Image = (Image)resources.GetObject("alien.Image");
            alien.Location = new Point(12, 9);
            alien.Name = "alien";
            alien.Size = new Size(49, 38);
            alien.SizeMode = PictureBoxSizeMode.StretchImage;
            alien.TabIndex = 2;
            alien.TabStop = false;
            alien.Tag = "enemy";
            // 
            // stars1
            // 
            stars1.Image = (Image)resources.GetObject("stars1.Image");
            stars1.Location = new Point(2, 355);
            stars1.Name = "stars1";
            stars1.Size = new Size(436, 652);
            stars1.SizeMode = PictureBoxSizeMode.StretchImage;
            stars1.TabIndex = 3;
            stars1.TabStop = false;
            // 
            // stars2
            // 
            stars2.Image = (Image)resources.GetObject("stars2.Image");
            stars2.Location = new Point(2, -50);
            stars2.Name = "stars2";
            stars2.Size = new Size(436, 415);
            stars2.SizeMode = PictureBoxSizeMode.StretchImage;
            stars2.TabIndex = 4;
            stars2.TabStop = false;
            // 
            // scoreValue
            // 
            scoreValue.AutoSize = true;
            scoreValue.BackColor = Color.Transparent;
            scoreValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreValue.ForeColor = SystemColors.ActiveCaption;
            scoreValue.Location = new Point(12, 9);
            scoreValue.Name = "scoreValue";
            scoreValue.Size = new Size(73, 21);
            scoreValue.TabIndex = 5;
            scoreValue.Text = "Score : 0";
            // 
            // alien2
            // 
            alien2.BackColor = Color.Transparent;
            alien2.Image = (Image)resources.GetObject("alien2.Image");
            alien2.Location = new Point(375, 12);
            alien2.Name = "alien2";
            alien2.Size = new Size(49, 38);
            alien2.SizeMode = PictureBoxSizeMode.StretchImage;
            alien2.TabIndex = 6;
            alien2.TabStop = false;
            alien2.Tag = "enemy";
            // 
            // alien3
            // 
            alien3.BackColor = Color.Transparent;
            alien3.Image = (Image)resources.GetObject("alien3.Image");
            alien3.Location = new Point(318, 45);
            alien3.Name = "alien3";
            alien3.Size = new Size(49, 38);
            alien3.SizeMode = PictureBoxSizeMode.StretchImage;
            alien3.TabIndex = 7;
            alien3.TabStop = false;
            alien3.Tag = "enemy";
            // 
            // alien4
            // 
            alien4.BackColor = Color.Transparent;
            alien4.Image = (Image)resources.GetObject("alien4.Image");
            alien4.Location = new Point(90, 48);
            alien4.Name = "alien4";
            alien4.Size = new Size(49, 38);
            alien4.SizeMode = PictureBoxSizeMode.StretchImage;
            alien4.TabIndex = 8;
            alien4.TabStop = false;
            alien4.Tag = "enemy";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(354, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(390, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(237, 241);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 12;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(281, 241);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 13;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(302, 241);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 14;
            label3.Text = "A";
            // 
            // timer2
            // 
            timer2.Interval = 250;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 250;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 250;
            timer4.Tick += timer4_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(436, 436);
            Controls.Add(scoreValue);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(alien4);
            Controls.Add(alien3);
            Controls.Add(alien2);
            Controls.Add(alien);
            Controls.Add(ufo);
            Controls.Add(spaceship);
            Controls.Add(stars1);
            Controls.Add(stars2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Space Invaders    ~by Bugra   ";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)spaceship).EndInit();
            ((System.ComponentModel.ISupportInitialize)ufo).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien).EndInit();
            ((System.ComponentModel.ISupportInitialize)stars1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stars2).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien2).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien3).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox spaceship;
        private System.Windows.Forms.Timer timer1;
        private PictureBox ufo;
        private PictureBox alien;
        private PictureBox stars1;
        private PictureBox stars2;
        private Label scoreValue;
        private PictureBox alien2;
        private PictureBox alien3;
        private PictureBox alien4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}