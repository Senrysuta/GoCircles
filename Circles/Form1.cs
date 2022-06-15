using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        int speed = 12;
        Random random = new Random();
        int NumberLeft = 1;
        int NumberTop = 0;
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, mainCircle.Width, mainCircle.Height);
            mainCircle.Region = new Region(path);

            pictureBoxes.Add(mainCircle);


        }

        private void mainTimerEvent(object sender, EventArgs e)
        { 
            moveCircle(); 
        }

        private void moveCircle()
        {



            foreach(PictureBox Circles in pictureBoxes)
            {
                if (Circles.Left < 0)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.AccessibleDescription = "1";
                    Circles.Tag = random.Next(2).ToString();

                }
                else if (Circles.Left > 623)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.AccessibleDescription = "0";
                    Circles.Tag = random.Next(2).ToString();

                }
                else if (Circles.Top < 0)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.Tag = "1";
                    Circles.AccessibleDescription = random.Next(2).ToString();

                }
                else if (Circles.Top > 338)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.Tag = "0";
                    Circles.AccessibleDescription = random.Next(2).ToString();

                }

                if (Circles.AccessibleDescription == "0" && Circles.Tag.ToString() == "0")
                {
                    Circles.Left -= speed;
                    Circles.Top -= speed - 2;
                }

                else if (NumberLeft == 1 && NumberTop == 1)
                {
                    Circles.Left += speed;
                    Circles.Top += speed + 2;
                }

                else if (NumberLeft == 0 && NumberTop == 1)
                {
                    Circles.Left -= speed;
                    Circles.Top += speed + 2;
                }

                else if (NumberLeft == 1 && NumberTop == 0)
                {
                    Circles.Left += speed;
                    Circles.Top -= speed - 2;
                }
            }        

        }

       /* private void checkBorder()
        {

            foreach(PictureBox Circles in pictureBoxes)
            {
                if (Circles.Left < 0)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.AccessibleDescription = "1";
                    Circles.Tag = random.Next(2).ToString();

                }
                else if (Circles.Left > 623)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.AccessibleDescription = "0";
                    Circles.Tag = random.Next(2).ToString();

                }
                else if (Circles.Top < 0)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.Tag = "1";
                    Circles.AccessibleDescription = random.Next(2).ToString();

                }
                else if (Circles.Top > 338)
                {
                    pictureBoxes.Add(createPictureBox(Circles.Width, Circles.Height, Circles.Left, Circles.Top));
                    Circles.Tag = "0";
                    Circles.AccessibleDescription = random.Next(2).ToString();

                }
            }


        }*/

        public PictureBox createPictureBox(int width, int height, int x, int y)
        {
            var pictureBox = new PictureBox
            {
                Name = "newCircle",
                Size = new Size(width / 2, height / 2),
                Location = new Point(x, y),
                BackColor = Color.Blue,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = "",
                AccessibleDescription = ""
            };

            this.Controls.Add(pictureBox);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);


            return pictureBox;
        }
    }      
}
