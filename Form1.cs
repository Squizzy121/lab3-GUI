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
        public Graphics graph;
        public string name = "obj";
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    class Figure
    {
        int x { get; set; }
        int y { get; set; }
        int size { get; set; }
        string name { get; set; }
        Color color { get; set; }
        Pen pen = new Pen(Color.BlueViolet, 1);
        public Figure(string name, int size)
        {
            Random ran = new Random();
            this.x = ran.Next(0, 472);
            this.y = ran.Next(0, 326);
            this.name = name;
            this.size = size;
        }
        public void Draw(PictureBox pictureBox1)
        {
            pen.Color = color;
            Graphics graph = pictureBox1.CreateGraphics();
            Rectangle rect1 = new Rectangle(x, y, 90, 90);
            graph.DrawRectangle(pen, rect1);
            graph.DrawEllipse(pen, x, y, 90, 90);
            Rectangle rect2 = new Rectangle(x + 13, y + 13, 65, 65);
            graph.DrawRectangle(pen, rect2);
        }
        public delegate void del();
        static del[] delegates = new del[]
        {
            new del(()=>x++),
            new del(()=>x--),
            new del(()=>y++),
            new del(()=>y--),
            new del(()=>size++),
            new del(()=>size--),
            new del(()=>color=Color.White),
            new del(()=>color=Color.BlueViolet)
        };
        public void MoveU()
        {
            del[3]();
        }
        public void MoveD()
        {
            del[2]();
        }
        public void MoveR()
        {
            del[0]();
        }
        public void MoveL()
        {
            del[1]();
        }
        public void SizeU()
        {
            del[4]();
        }
        public void SizeD()
        {
            del[5]();
        }
        public void Hide()
        {
            del[6]();
        }
        public void Show()
        {
            del[7]();
        }
    }
}
