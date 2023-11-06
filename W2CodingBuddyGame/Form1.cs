using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;

namespace W2CodingBuddyGame
{
    public partial class Form1 : Form
    {
        int Speed = 2; // Car Speed
        int sRoad = 5; // Road Speed
        int Score = 0; // Scoring
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown; // A = left - D = right
        }

        //Starts Game
        private void Start() 
        {
            sRoad = 3;
            Score = 0;

            scoreTimer.Start();
        }

        //On button click game starts.
        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }


        //Game scoring and road movement
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            Score++;
            label1.Text = "" + Score;

            //Moves road with speed set in sRoad
            roadG.Top += sRoad;
            roadG2.Top += sRoad;

            //Once road reaches 600 score it resets
            if (roadG.Top > 375)
            {
                roadG.Top = -375;
            }
            if (roadG2.Top > 380)
            {
                roadG2.Top = -380;
            }

        }

        //On stop button click game stops
        private void button2_Click(object sender, EventArgs e)
        {
            scoreTimer.Stop();
        }


        //Movement of car
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = playerCAR.Location.X;
            int y = playerCAR.Location.Y;

            if (e.KeyCode == Keys.D) x += 4;
            else if (e.KeyCode == Keys.A) x -= 4;

            playerCAR.Location = new Point(x, y);
        }
    }
}