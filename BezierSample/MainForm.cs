using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //float ax = 10f;
            //float ay = 10f;

            //float bx = 10f;
            //float by = 400f;

            //float cx = 400f;
            //float cy = 400f;

            var ax = float.Parse(AXTextBox.Text);
            var ay = float.Parse(AYTextBox.Text);
            var bx = float.Parse(BXTextBox.Text);
            var by = float.Parse(BYTextBox.Text);
            var cx = float.Parse(CXTextBox.Text);
            var cy = float.Parse(CYTextBox.Text);

            Pen pen = new Pen(Brushes.Blue, 1);
            Font font = new Font(new FontFamily("Arial"), 16);

            float tx = ax;
            float ty = ay;

            var A = new PointF(ax, ay);
            var B = new PointF(bx, by);
            var C = new PointF(cx, cy);

            using (var g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.White);

                g.DrawString("A", font, Brushes.Red, A);
                g.DrawString("B", font, Brushes.Red, B);
                g.DrawString("C", font, Brushes.Red, C);

                g.DrawLine(pen, A, B);

                g.DrawLine(pen, B, C);

                for (float percent = 0; percent < 1; percent += 0.001f)
                {
                    var dx = ax + (bx - ax) * percent;
                    var dy = ay + (by - ay) * percent;

                    var ex = bx + (cx - bx) * percent;
                    var ey = by + (cy - by) * percent;

                    var fx = dx + (ex - dx) * percent;
                    var fy = dy + (ey - dy) * percent;

                    g.DrawLine(pen, tx, ty, fx, fy);
                    tx = fx;
                    ty = fy;
                }
            }
        }
    }
}
