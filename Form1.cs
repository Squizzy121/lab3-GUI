using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public int count = 1;
        public bool rotate = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            CEmblem figure = new CEmblem("Фигура №" + count);
            figure.Show();
            figure.Draw(pictureBox1,rotate);
            comboBox1.Items.Add(figure);
            count++;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveU();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveR();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveL();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveD();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveUU();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveRR();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveLL();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.MoveDD();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.SizeU();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1,rotate);
            figure.SizeD();
            figure.Show();
            figure.Draw(pictureBox1,rotate);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1, rotate);
            if (rotate)
            {
                rotate = false;
            }
            else
            {
                rotate = true;
            }
            figure.Show();
            figure.Draw(pictureBox1, rotate);
        }
    }
    public class CEmblem
    {
        static Random ran = new Random();
        int x= ran.Next(0, 472);
        int y= ran.Next(0, 326);
        int size = 90;
        string name { get; set; }
        Color color = Color.BlueViolet;
        Pen pen = new Pen(Color.BlueViolet, 1);
        public CEmblem(string name)
        {
            this.name = name;
        }
        public void Draw(PictureBox pictureBox1,bool rotate)
        {

            pen.Color = color;
            Graphics graph = pictureBox1.CreateGraphics();
            if (!rotate)
            {
                PointF[] rect1 = new PointF[]
                {
                new PointF(x,y),
                new PointF(x+size,y),
                new PointF(x+size,y+size),
                new PointF(x,y+size)
                };
                PointF[] rect2 = new PointF[]
                {
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)),
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2)+(int)(Math.Sqrt(2*size/2*size/2)), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)),
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2)+(int)(Math.Sqrt(2*size/2*size/2)), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)+(int)(Math.Sqrt(2*size/2*size/2))),
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)+(int)(Math.Sqrt(2*size/2*size/2)))
                };
                graph.DrawPolygon(pen, rect1);
                graph.DrawEllipse(pen, x, y, size, size);
                graph.DrawPolygon(pen, rect2);

            }
            else
            {
                int x0 = x + size / 2;
                int y0 = y + size / 2;
                PointF[] rect1 = new PointF[]
                {
                    new PointF((int)((x-x0)*Math.Cos(45*Math.PI/180)-(y-y0)*Math.Sin(45*Math.PI/180)+x0),(int)((x-x0)*Math.Sin(45*Math.PI/180)+(y-y0)*Math.Cos(45*Math.PI/180)+y0)),
                new PointF((int)((x+size-x0)*Math.Cos(45*Math.PI/180)-(y-y0)*Math.Sin(45*Math.PI/180)+x0),(int)((x-x0)*Math.Sin(45*Math.PI/180)+(y-y0)*Math.Cos(45*Math.PI/180)+y0)),
                new PointF((int)((x+size-x0)*Math.Cos(45*Math.PI/180)-(y+size-y0)*Math.Sin(45*Math.PI/180)+x0),(int)((x-x0)*Math.Sin(45*Math.PI/180)+(y-y0)*Math.Cos(45*Math.PI/180)+y0)),
                new PointF((int)((x-x0)*Math.Cos(45*Math.PI/180)-(y+size-y0)*Math.Sin(45*Math.PI/180)+x0),(int)((x-x0)*Math.Sin(45*Math.PI/180)+(y-y0)*Math.Cos(45*Math.PI/180)+y0))
                };
                PointF[] rect2 = new PointF[]
                {
                    new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)),
               //new PointF(((x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2))-x0)*Math.Cos(45*Math.PI/180)-(y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2))-y0)*Math.Sin(45*Math.PI/180),((x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2))-x0)*Math.Cos(45*Math.PI/180)-(y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2))-y0)*Math.Sin(45 * Math.PI / 180)),
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2)+(int)(Math.Sqrt(2*size/2*size/2)), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)),
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2)+(int)(Math.Sqrt(2*size/2*size/2)), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)+(int)(Math.Sqrt(2*size/2*size/2))),
                new PointF(x + (int)((size-Math.Sqrt(2 * Math.Pow(size/2, 2)))/2), y + (int)((size - (int)(Math.Sqrt(2 * Math.Pow(size/2, 2)))) / 2)+(int)(Math.Sqrt(2*size/2*size/2)))
                };
                graph.DrawPolygon(pen, rect1);
                graph.DrawEllipse(pen, x, y, size, size);
                graph.DrawPolygon(pen, rect2);
            }
        }
        public override string ToString()
        {
            return name;
        }
        public void MoveU()
        {
            if (y >= 1)
            {
                y--;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveD()
        {
            if (y<=326)
            {
                y++;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveR()
        {
            if (x<=472)
            {
                x++;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveL()
        {
            if (x>=1)
            {
                x--;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveUU()
        {
            if (y>1)
            {
                y=1;
            }
        }
        public void MoveDD()
        {
           if (y<=426-size)
            {
                y = 426-size;
            }
        }
        public void MoveRR()
        {
            if (x <= 572-size)
            {
                x=572-size;
            }
        }
        public void MoveLL()
        {
            if (x >= 1)
            {
                x=1;
            }
        }
        public void SizeU()
        {
            if (size <= 200)
            {
                size++;
            }
            else if (x+size>=570)
            {
                MessageBox.Show("Вы достигли границ холста");
            }
            else
            {
                MessageBox.Show("Достигнут максимальный размер фигуры!");
            }
        }
        public void SizeD()
        {
            if (size >= 25)
            {
                size--;
            }
            else
            {
                MessageBox.Show("Достигнут минимальный размер фигуры!");
            }
        }
        public void Hide()
        {
            color = PictureBox.DefaultBackColor;
        }
        public void Show()
        {
            color = Color.BlueViolet;
        }
    }
}
