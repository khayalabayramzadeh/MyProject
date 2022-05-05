using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        Point startLocation;
        int countDown = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            GamerTimer.Start();
            startLocation = panel1.Location;
            Cursor.Position = PointToScreen(startLocation);
            countDown = 30;
        }

        private void LabyrinthWall_MouseEnter(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void panelOuter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            if(countDown < 0)
            {
                GamerTimer.Stop();
                DialogResult userChoice = MessageBox.Show("You lost\nPlay Again","Information",MessageBoxButtons.YesNo);

                if (userChoice == DialogResult.Yes)
                {
                    InitializeGame();
                }
                else
                {
                    this.Close();
                }
            }

            lblTimer.Text = countDown.ToString();
            countDown--;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            GamerTimer.Stop();
            DialogResult userChoice = MessageBox.Show("You Win!!!\nPlay Again", "Information", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                InitializeGame();
            }
            else
            {
                this.Close();
            }
        }
    }
}
