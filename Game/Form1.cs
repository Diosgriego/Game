using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game
{
    public partial class Form1 : Form
    {
        PictureBox[] fog;
        int backGroundspeed; // скорость тумана
        Random rnd;
        int playerSpeed;

        PictureBox[] bullets;
        int bulletsSpeed;

        int Score;
        int Level;

        WindowsMediaPlayer shoot;
        WindowsMediaPlayer GameSong;
        WindowsMediaPlayer Rip;
        WindowsMediaPlayer KillPlayer;

        PictureBox[] opponent;
        int sizeOpponent;
        int opponentSpeed;
        public Form1()
        {
            InitializeComponent();
        }

        private void backGround_Tick(object sender, EventArgs e)
        {
            // смещение тумана
            for (int i = 0; i < fog.Length; i++)
            {
                fog[i].Left += backGroundspeed;

                if (fog[i].Left >= 1280)
                {
                    fog[i].Left = fog[i].Height;
                }
            }

            for (int i = fog.Length; i < fog.Length; i++)
            {
                fog[i].Left += backGroundspeed - 10;

                if (fog[i].Left >= 2000)
                {
                    fog[i].Left = fog[i].Left;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            backGroundspeed = 5;
            fog = new PictureBox[20];
            rnd = new Random();
            playerSpeed = 4 ;

            bullets = new PictureBox[1];
            bulletsSpeed = 50;

            shoot = new WindowsMediaPlayer();
            shoot.URL = "songs\\shoot.mp3";
            shoot.settings.volume = 5;

            Rip = new WindowsMediaPlayer();
            Rip.URL = "songs\\Rip.mp3";
            Rip.settings.volume = 15;

            KillPlayer = new WindowsMediaPlayer();
            KillPlayer.URL = "songs\\KillPlayer.mp3";
            KillPlayer.settings.volume = 15;

            GameSong = new WindowsMediaPlayer();
            GameSong.URL = "songs\\songGame.mp3";
            GameSong.settings.setMode("loop", true);
            GameSong.settings.volume = 20;

            opponent = new PictureBox[5];
            int sizeOpponent = rnd.Next(60, 80);
            opponentSpeed = 5;

            Score = 0;
            Level = 1;



            Image easyOpponent = Image.FromFile("assets\\opp.png");

            for(int i = 0; i < opponent.Length; i++)
            {
                opponent[i] = new PictureBox();
                opponent[i].Size = new Size(sizeOpponent, sizeOpponent);
                opponent[i].SizeMode = PictureBoxSizeMode.Zoom;
                opponent[i].BackColor = Color.Transparent;
                opponent[i].Image = easyOpponent;
                opponent[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 600, rnd.Next(150, 300));

                this.Controls.Add(opponent[i]);
            }

            for( int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(30, 10);
                bullets[i].BackColor = Color.Red;

                this.Controls.Add(bullets[i]);

            }

            // инициализация тумана

            for (int i = 0; i < fog.Length; i++)
            {
                fog[i] = new PictureBox();
                fog[i].BorderStyle = BorderStyle.None;
                
                fog[i].Location = new Point(rnd.Next(-4000, 2000), rnd.Next(150, 300)); // кординаты рандомного появления тумана
                
                // 2 вида тумана, четный одного размера, нечетный другого
                if (i % 2 == 1)
                {
                    // размер тумана в диапозоне
                    fog[i].Size = new Size(rnd.Next(100, 255), rnd.Next(30, 70));
                    
                    fog[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200); // рандомная прозрачность тумана
                }
                else
                {
                    fog[i].Size = new Size(100, 30);
                    fog[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 205, 205);
                }
                this.Controls.Add(fog[i]);
            }

            GameSong.controls.play();
        }

        private void Left_Tick(object sender, EventArgs e)
        {
            if(mainPlayer.Left > 10)
            {
                mainPlayer.Left -= playerSpeed; 
            }
        }

        private void Right_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left < 1150)
            {
                mainPlayer.Left += playerSpeed;
            }
        }

        private void Up_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top -= playerSpeed;
        }

        private void Down_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top += playerSpeed;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.PlayerStay;

            if (e.KeyCode == Keys.Left)
            {
                Left.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                Right.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                Up.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                Down.Start();
            }
            if(e.KeyCode == Keys.Space)
            {
                shoot.controls.play();
                for(int i = 0; i < bullets.Length; i++)
                {
                    Intersect();
                    if (bullets[i].Left > 1280)
                    {
                        bullets[i].Location = new Point(mainPlayer.Location.X + 10 + i *10, mainPlayer.Location.Y + 58);
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.PlayerStay;

            Left.Stop();
            Right.Stop();
            Up.Stop();
            Down.Stop();
        }

        private void BulletsTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Left += bulletsSpeed;
            }
        }

        private void oppTimer_Tick(object sender, EventArgs e)
        {
            MoveOpp(opponent, opponentSpeed);
        }

        private void MoveOpp(PictureBox[] opponent, int speed)
        {
            for (int i = 0; i < opponent.Length; i++)
            {
                opponent[i].Left -= speed + (int)(Math.Sin(opponent[i].Left) * Math.PI / 180);

                Intersect();

                if (opponent[i].Left < 0)
                {
                    int sizeOpponent = rnd.Next(60, 90);
                    opponent[i].Size = new Size(sizeOpponent, sizeOpponent);
                    opponent[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 600, rnd.Next(150, 400));

                }
            }
        }

        private void Intersect()
        {
            for(int i = 0;i < opponent.Length;i++)
            {
                if (bullets[0].Bounds.IntersectsWith(opponent[i].Bounds))
                {
                    Rip.controls.play();

                    Score += 1;
                    labelScore.Text = (Score <10) ? "0" + Score.ToString() : Score.ToString();

                    if(Score % 10 == 0)
                    {
                        Level += 1;
                        labelLevel.Text = (Level < 10) ? "0" + Level.ToString() : Level.ToString();

                        if(opponentSpeed <= 3)
                        {
                            opponentSpeed++;
                        }

                        if(Level == 10)
                        {
                            GameOver("Epic Power!");
                        }
                    }

                    opponent[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 800, rnd.Next(150, 300));
                    bullets[0].Location = new Point(1000, mainPlayer.Location.Y);
                }

                if (mainPlayer.Bounds.IntersectsWith(opponent[i].Bounds))
                {
                    mainPlayer.Visible = false;

                    GameOver("Game Over");
                }
            }
        }
        
        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(400, 40);
            label1.Visible = true;

            GameSong.controls.stop();
            oppTimer.Stop();
            KillPlayer.controls.play();

        }
    }
}
