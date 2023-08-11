using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class CustomMessageBox: Form
    {
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }

        }
        public CustomMessageBox()
        {
            // İletişim kutusu ayarları
            this.Text = "Game Over";
            this.Size = new Size(300, 200);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        
        // Metin ekleme
        Label label = new Label();
            label.Text = "Game Over!";
            label.Location = new Point(50, 50);
            this.Controls.Add(label);

            // Buton ekleme
            Button restartButton = new Button();
            restartButton.Text = "Restart";
            restartButton.Location = new Point(100, 100);
            restartButton.Click += restartButton_Click;
            this.Controls.Add(restartButton);

            Button quitButton = new Button();
            quitButton.Text = "Quit";
            quitButton.Location = new Point(200, 100);
            quitButton.Click += QuitButton_Click;
            this.Controls.Add(quitButton);


        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
