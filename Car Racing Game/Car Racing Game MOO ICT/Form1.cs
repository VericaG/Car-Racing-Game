using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 11;
        int score;
        int carImage;
        int fuel = 1000;
        int fuelDecrease = 1.5;
        Random fuelPosition = new Random();


        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        int shieldCount = 3;
        bool isShieldActive = false; 
        int shieldDuration = 9; 
        DateTime shieldActivationTime; 


        public Form1()
        {
            InitializeComponent();
            PopulateCarSelection();

            RespawnFuelCanister();
           

        }
        private void RespawnFuelCanister()

        {

            fuelCanister.Image = Properties.Resources.fuel; 
            fuelCanister.Size = new Size(50, 50); 
            fuelCanister.SizeMode = PictureBoxSizeMode.StretchImage;
            bool validPosition = false;

            while (!validPosition)
            {
                int newX = fuelPosition.Next(5, 400);
                int newY = fuelPosition.Next(100, 500) * -1;

                Rectangle fuelRect = new Rectangle(newX, newY, fuelCanister.Width, fuelCanister.Height);
                Rectangle AI1Rect = new Rectangle(AI1.Left, AI1.Top, AI1.Width, AI1.Height);
                Rectangle AI2Rect = new Rectangle(AI2.Left, AI2.Top, AI2.Width, AI2.Height);

                if (!fuelRect.IntersectsWith(AI1Rect) && !fuelRect.IntersectsWith(AI2Rect))
                {
                    fuelCanister.Location = new Point(newX, newY);
                    validPosition = true;
                }

            }
            this.Controls.Add(fuelCanister);
            fuelCanister.BringToFront(); 
        }

        private void PopulateCarSelection()
        {
            carSelectionCombo.Items.Add("ambulance");
            carSelectionCombo.Items.Add("carGreen");
            carSelectionCombo.Items.Add("carGrey");
            carSelectionCombo.Items.Add("carOrange");
            carSelectionCombo.Items.Add("carPink");
            carSelectionCombo.Items.Add("CarRed");
            carSelectionCombo.Items.Add("carYellow");
            carSelectionCombo.Items.Add("TruckBlue");
            carSelectionCombo.Items.Add("TruckWhite");

     
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                ActivateShield();
            }
        }

        private void ActivateShield()
        {
            if (shieldCount > 0 && !isShieldActive)
            {
                isShieldActive = true;
                shieldCount--; 
                shieldCountLabel.Text = "Штитови: " + shieldCount;


                shieldActivationTime = DateTime.Now;
            }
        }

       

        private void gameTimerEvent(object sender, EventArgs e)
        {
            fuelLabel.Text = "Гориво: " + fuel;
            txtScore.Text = "Score: " + score;
            score++;
            fuel -= fuelDecrease;

            if (fuel <= 0)
            {
                gameOverNoFuel();
            }

            if (goleft && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goright && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            fuelCanister.Top += roadSpeed;
            if (fuelCanister.Top > 500 || fuelCanister.Left > 350 || fuelCanister.Right > 350)
            {
                RespawnFuelCanister();
            }

            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }
            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }


            if (isShieldActive)
            {
                labelaStit.Text = "Имате активирано штит";
                TimeSpan timeSinceActivation = DateTime.Now - shieldActivationTime;
                double secondsElapsed = timeSinceActivation.TotalSeconds;

                if (secondsElapsed >= shieldDuration)
                {
                    isShieldActive = false;
                    labelaStit.Text = "";

                }
            }


            if (!isShieldActive && (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds)))
            {
                gameOver();
            }

            if (player.Bounds.IntersectsWith(fuelCanister.Bounds))
            {
                if (shieldCount > 0)
                {
                    fuel += 100;
                    RespawnFuelCanister();
                    fuelCanister.Image = null;
                }
            }

            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 18;
                trafficSpeed = 20;
            }
            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 25;
                roadSpeed = 23;
            }
        }


        private void changeAIcars(PictureBox tempCar)
        {

            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }


            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
            carSelectionCombo.Enabled = true;
            fuel = 1000;



        }
        public void gameOverNoFuel()
        {
            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
            carSelectionCombo.Enabled = true;
            fuel = 1000;
            score = 0;

            fuelLabel.Text = "Гориво: " + fuel;
            txtScore.Text = "Score: " + score;
            gameTimer.Stop();
            MessageBox.Show("Немате доволно гориво!");

        }

        private void ResetGame()
        {

            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;
            changeCar();

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();
            carSelectionCombo.Enabled = false;

            shieldCount = 3; 
            isShieldActive = false; 

        }
        public void changeCar()
        {
            if (carSelectionCombo.SelectedItem != null)
            {

                string selectedCar = carSelectionCombo.SelectedItem.ToString();
                switch (selectedCar)
                {
                    case "ambulance":
                        player.Image = Properties.Resources.ambulance;
                        break;
                    case "carGreen":
                        player.Image = Properties.Resources.carGreen;
                        break;
                    case "carGrey":
                        player.Image = Properties.Resources.carGrey;
                        break;
                    case "carOrange":
                        player.Image = Properties.Resources.carOrange;
                        break;
                    case "carPink":
                        player.Image = Properties.Resources.carPink;
                        break;
                    case "CarRed":
                        player.Image = Properties.Resources.CarRed;
                        break;
                    case "carYellow":
                        player.Image = Properties.Resources.carYellow;
                        break;
                    case "TruckBlue":
                        player.Image = Properties.Resources.TruckBlue;
                        break;
                    case "TruckWhite":
                        player.Image = Properties.Resources.TruckWhite;
                        break;
                }
            }
        }


        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void carSelectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fuelLabel_Click(object sender, EventArgs e)
        {

        }

        private void fuelCanister_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();

        }
    }
}
