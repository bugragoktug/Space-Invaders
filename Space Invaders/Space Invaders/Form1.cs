using System;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        private bool spacePressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        bool right, left, fire;
        void bulletMovement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 10)
                        this.Controls.Remove(x);
                }
            }
        }
        int score = 0;
        void scoreval()
        {
            foreach (Control a in this.Controls)
            {
                foreach (Control b in this.Controls)
                {
                    if (a is PictureBox && a.Tag == "bullet")
                    {
                        if (b is PictureBox && b.Tag == "enemy")
                        {
                            if (a.Bounds.IntersectsWith(b.Bounds))
                            {
                                b.Top = -100;
                                ((PictureBox)a).Image = Properties.Resources.explosion;
                                a.Top = b.Top;
                                score++;
                                scoreValue.Text = "Score : " + score;
                            }
                        }
                    }
                }
            }
        }
        void starsMovement()
        {
            stars1.Top += 7;
            stars2.Top += 7;
            if (stars1.Top >= 452)
            {
                stars1.Top = -440;
            }
            else if (stars2.Top >= 452)
            {
                stars2.Top = -440;
            }
        }

        void aliensMovement()
        {
            Random random = new Random();
            if (alien.Top >= 452)
            {
                int x = random.Next(0, 252);
                alien.Location = new Point(x, 0);
            }
            else if (ufo.Top >= 452)
            {

                int y = random.Next(0, 252);
                ufo.Location = new Point(y, 0);
            }
            else if (alien2.Top >= 452)
            {

                int z = random.Next(0, 452);
                alien2.Location = new Point(z, 0);
                alien2.Location = new Point(z, 0);
            }
            else if (alien3.Top >= 452)
            {

                int z = random.Next(0, 452);
                alien3.Location = new Point(z, 0);
                alien3.Location = new Point(z, 0);
            }
            else if (alien4.Top >= 452)
            {

                int z = random.Next(0, 452);
                alien4.Location = new Point(z, 0);
                alien4.Location = new Point(z, 0);
            }
            else
            {
                alien.Top = alien.Top + 6;
                ufo.Top = ufo.Top + 5;
                alien2.Top = alien2.Top + 6;
                alien3.Top = alien3.Top + 6;
                alien4.Top = alien4.Top + 6;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            ufo.BackColor = Color.Transparent;
            spaceship.BackColor = Color.Transparent;
            alien.BackColor = Color.Transparent;
            alien2.BackColor = Color.Transparent;
            alien3.BackColor = Color.Transparent;
            alien4.BackColor = Color.Transparent;
        }
        public void spaceshipMovement()
        {
            if (right == true)
            {
                if (spaceship.Left < 385)
                {
                    spaceship.Left = spaceship.Left + 7;
                }
            }
            else if (left == true)
            {
                if (spaceship.Left > -20)
                {
                    spaceship.Left = spaceship.Left - 7;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space)
            {
                if (!spacePressed)
                {
                    spacePressed = true;
                    Task.Delay(250).ContinueWith(_ =>
                    {
                        spacePressed = false;
                    });
                    PictureBox bullet = new PictureBox();
                    bullet.SizeMode = PictureBoxSizeMode.AutoSize;
                    bullet.Image = Properties.Resources.bullet_img;
                    bullet.BackColor = System.Drawing.Color.Transparent;
                    bullet.Tag = "bullet";

                    bullet.Left = spaceship.Left + 27;
                    bullet.Top = spaceship.Top - 35;
                    this.Controls.Add(bullet);
                    bullet.BringToFront();
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                fire = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            spaceshipMovement();
            aliensMovement();
            starsMovement();
            bulletMovement();
            scoreval();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "A" && spaceship.Bounds.IntersectsWith(ufo.Bounds) || spaceship.Bounds.IntersectsWith(alien.Bounds) || spaceship.Bounds.IntersectsWith(alien2.Bounds) || spaceship.Bounds.IntersectsWith(alien3.Bounds) || spaceship.Bounds.IntersectsWith(alien4.Bounds))
            {

                if (alien.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien.Top = -500; timer2.Stop(); timer2.Tick -= timer2_Tick;
                    timer3.Start();
                    label1.Text = "B";
                    pictureBox1.Hide();

                }
                else if (alien2.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien2.Top = -500; timer2.Stop(); timer2.Tick -= timer2_Tick;
                    timer3.Start();
                    label1.Text = "B";
                    pictureBox1.Hide();
                }
                else if (alien3.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien3.Top = -500; timer2.Stop(); timer2.Tick -= timer2_Tick;
                    timer3.Start();
                    label1.Text = "B";
                    pictureBox1.Hide();
                }
                else if (alien4.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien4.Top = -500; timer2.Stop(); timer2.Tick -= timer2_Tick;
                    timer3.Start();
                    label1.Text = "B";
                    pictureBox1.Hide();
                }
                else if (ufo.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    ufo.Top = -500; timer2.Stop(); timer2.Tick -= timer2_Tick;
                    timer3.Start();
                    label1.Text = "B";
                    pictureBox1.Hide();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label2.Text == "A" && spaceship.Bounds.IntersectsWith(ufo.Bounds) || spaceship.Bounds.IntersectsWith(alien.Bounds) || spaceship.Bounds.IntersectsWith(alien2.Bounds) || spaceship.Bounds.IntersectsWith(alien3.Bounds) || spaceship.Bounds.IntersectsWith(alien4.Bounds))
            {

                if (alien.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien.Top = -500; timer3.Stop(); timer3.Tick -= timer3_Tick;
                    timer4.Start();
                    label2.Text = "B";
                    pictureBox2.Hide();

                }
                else if (alien2.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien2.Top = -500; timer3.Stop(); timer3.Tick -= timer3_Tick;
                    timer4.Start();
                    label2.Text = "B";
                    pictureBox2.Hide();
                }
                else if (alien3.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien3.Top = -500; timer3.Stop(); timer3.Tick -= timer3_Tick;
                    timer4.Start();
                    label2.Text = "B";
                    pictureBox2.Hide();
                }
                else if (alien4.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien4.Top = -500; timer3.Stop(); timer3.Tick -= timer3_Tick;
                    timer4.Start();
                    label2.Text = "B";
                    pictureBox2.Hide();
                }
                else if (ufo.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    ufo.Top = -500; timer3.Stop(); timer3.Tick -= timer3_Tick;
                    timer4.Start();
                    label2.Text = "B";
                    pictureBox2.Hide();
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (label3.Text == "A" && spaceship.Bounds.IntersectsWith(ufo.Bounds) || spaceship.Bounds.IntersectsWith(alien.Bounds) || spaceship.Bounds.IntersectsWith(alien2.Bounds) || spaceship.Bounds.IntersectsWith(alien3.Bounds) || spaceship.Bounds.IntersectsWith(alien4.Bounds))
            {
                if (alien.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien.Top = -500;
                    timer4.Stop(); timer4.Tick -= timer4_Tick;
                    label3.Text = "B";
                    pictureBox3.Hide();
                    timer1.Stop();
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.ShowDialog();

                }
                else if (alien2.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien2.Top = -500; timer4.Stop(); timer4.Tick -= timer4_Tick;
                    label3.Text = "B";
                    pictureBox3.Hide();
                    timer1.Stop();
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.ShowDialog();
                }
                else if (alien3.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien3.Top = -500; timer4.Stop(); timer4.Tick -= timer4_Tick;
                    label3.Text = "B";
                    pictureBox3.Hide();
                    timer1.Stop();
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.ShowDialog();
                }
                else if (alien4.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    alien4.Top = -500; timer4.Stop(); timer4.Tick -= timer4_Tick;
                    label3.Text = "B";
                    pictureBox3.Hide();
                    timer1.Stop();
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.ShowDialog();
                }
                else if (ufo.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    ufo.Top = -500; timer4.Stop(); timer4.Tick -= timer4_Tick;
                    label3.Text = "B";
                    pictureBox3.Hide();
                    timer1.Stop();
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.ShowDialog();
                }
            }
        }
    }
}