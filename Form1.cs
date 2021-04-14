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
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            CEmblem figure = new CEmblem("Фигура №" + count);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);
            count++;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveU();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveR();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveL();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveD();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveUU();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveRR();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveLL();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveDD();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.SizeU();
            figure.Show();
            figure.Draw(pictureBox1);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.SizeD();
            figure.Show();
            figure.Draw(pictureBox1);
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
        public void Draw(PictureBox pictureBox1)
        {

            pen.Color = color;
            Graphics graph = pictureBox1.CreateGraphics();
            Rectangle rect1 = new Rectangle(x, y, size, size);
            graph.DrawRectangle(pen, rect1);
            graph.DrawEllipse(pen, x, y, size, size);
            Rectangle rect2 = new Rectangle(x + 13, y + 13, Convert.ToInt32(size/Math.Sqrt(2)), Convert.ToInt32(size / Math.Sqrt(2)));
            graph.DrawRectangle(pen, rect2);
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
           if (y<=326)
            {
                y = 326;
            }
        }
        public void MoveRR()
        {
            if (x <= 472)
            {
                x=472;
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
