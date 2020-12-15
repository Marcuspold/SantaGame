using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int HouseSpeed = 7;
        int TreeSpeed = 7;
        int SnowSpeed = 7;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void timer1_tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            House.Left -= HouseSpeed;
            Tree1.Left -= TreeSpeed;
            Tree2.Left -= TreeSpeed;
            Snow1.Left -= SnowSpeed;
            Snow2.Left -= SnowSpeed;
            ScoreLabel.Text = $"score:{score}";

            if (House.Left < -100)
            {
                House.Left = 600;
                score++;
            }

            if (Tree1.Left < -100)
            {
                Tree1.Left = 600;
                score++;
            }

            if (Tree2.Left < -100)
            {
                Tree2.Left = 600;
                score++;
            }

            if (Snow1.Left < -100)
            {
                Snow1.Left = 600;
                score++;
            }

            if (Snow2.Left < -100)
            {
                Snow2.Left = 600;
                score++;
            }

            if (Santa.Top < -25)
            {
                GameOver();
            }

            if (Santa.Bounds.IntersectsWith(House.Bounds) || Santa.Bounds.IntersectsWith(Tree1.Bounds) ||
                Santa.Bounds.IntersectsWith(Snow1.Bounds) || Santa.Bounds.IntersectsWith(Tree2.Bounds) ||
                Santa.Bounds.IntersectsWith(Snow2.Bounds))
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            timer1.Stop();
            ScoreLabel.Text = $"Game Over You Lose ";
            PlayAgain.Visible = true;
            
        }

        private void Santa_Click(object sender, EventArgs e)
        {

        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Form1 NewFore = new Form1();
            NewFore.Show();
            this.Dispose(false);
        }
    }
}
