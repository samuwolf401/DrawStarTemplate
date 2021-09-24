using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        Point point1 = new Point(50, 9);
        Point point2 = new Point(62, 38);
        Point point3 = new Point(100, 39);
        Point point4 = new Point(70, 63);
        Point point5 = new Point(81, 100);
        Point point6 = new Point(50, 78);
        Point point7 = new Point(19, 100);
        Point point8 = new Point(30, 62);
        Point point9 = new Point(0, 39);
        Point point10 = new Point(38, 38);
        float scale;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black); 

            try
            {
                float size = Convert.ToSingle(sizeInput.Text);
                scale = size / 100;

                

                PointF[] star = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };
                for (int i = 1; i <= 10; i++)
                {
                    star[i].X *= scale;
                    star[i].Y *= scale;
                    

                }


                g.DrawPolygon(blackPen, star);
            }
            catch
            {

            }
           

        }


        private void fillButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            PointF[] star = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillPolygon(blackBrush,star);
        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
  
        }

    }
}
