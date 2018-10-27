using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<TwoPoint> listTwoPoints = new List<TwoPoint>();
        Point pointMause;
        Random randomX = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pointMause = new Point(e.X, e.Y);

            listTwoPoints.Clear();
            for (int i = 0; i < 25; i++)
            {
                listTwoPoints.Add(new TwoPoint(new Point(randomX.Next(1, pictureBox1.Width),
                    randomX.Next(1, pictureBox1.Height)), pointMause, Color.Black));
            }

            //listTwoPoints.Add(new TwoPoint(new Point(5,5), pointMause, Color.Black));
            //listTwoPoints.Add(new TwoPoint(new Point(5, pictureBox1.Height - 5), pointMause, Color.Black));
            //listTwoPoints.Add(new TwoPoint(new Point(pictureBox1.Width - 5,5), pointMause, Color.Black));
            //listTwoPoints.Add(new TwoPoint(new Point(pictureBox1.Width - 5, pictureBox1.Height - 5), pointMause, Color.Black));

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black);

            //Point[] points = new Point[] {
            //    new Point { X = point1.X, Y = point1.Y },
            //    new Point { X = point3.X, Y = point3.Y },
            //    new Point { X = pointMause.X, Y = pointMause.Y },
            //    new Point { X = point2.X, Y = point2.Y },
            //    new Point { X = point4.X, Y = point4.Y }
            //    };

            //Ctrl - A

            //Ctrl + KF

            //F12

            foreach (var item in listTwoPoints)
            {
                e.Graphics.DrawLine(new Pen(item.Color), item.X, item.Y);
            }
        }
    }

    class TwoPoint
    {
        public Point X { get; set; }
        public Point Y { get; set; }
        public Color Color { get; set; }

        public TwoPoint(Point x, Point y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}
