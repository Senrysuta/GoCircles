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

        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, mainCircle.Width, mainCircle.Height);
            mainCircle.Region = new Region(path);


        }

        private void mainTimerEvent(object sender, EventArgs e)
        {

            moveCircle();

           
        }

        private void moveCircle()
        {

            checkBorder();
            //label1.Text = Number.ToString();

            if (NumberLeft == 0 && NumberTop == 0)
            {
                mainCircle.Left -= speed;
                mainCircle.Top -= speed-1;
            }
                
            else if (NumberLeft == 1 && NumberTop == 1)
            {
                mainCircle.Left += speed;
                mainCircle.Top += speed+1;
            }

            else if (NumberLeft == 0 && NumberTop == 1)
            {
                mainCircle.Left -= speed;
                mainCircle.Top += speed+1;
            }

            else if (NumberLeft == 1 && NumberTop == 0)
            {
                mainCircle.Left += speed;
                mainCircle.Top -= speed-1;
            }

        }

        private void checkBorder()
        {

            if (mainCircle.Left < 0)
            {
                NumberLeft = 1;
                NumberTop = random.Next(2);
            }
            else if (mainCircle.Left > 623)
            {
                NumberLeft = 0;
                NumberTop = random.Next(2);
            }
            else if (mainCircle.Top < 0)
            {
                NumberTop = 1;
                NumberLeft = random.Next(2);
            }
            else if (mainCircle.Top > 338)
            {
                NumberTop = 0;
                NumberLeft = random.Next(2);
            }



        }


    }      
}
