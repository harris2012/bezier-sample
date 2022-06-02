using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly BindingList<Location> locations = new BindingList<Location>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            locations.Add(new Location { X = 0, Y = 0 });
            locations.Add(new Location { X = 0, Y = 100 });
            locations.Add(new Location { X = 100, Y = 100 });

            this.dataGridView1.DataSource = locations;
        }

        private void btAddRow_Click(object sender, EventArgs e)
        {
            this.locations.AddNew();
        }

        private void btDeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow location in this.dataGridView1.SelectedRows)
            {
                locations.RemoveAt(location.Index);
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Brushes.Blue, 1);
            Font font = new Font(new FontFamily("Arial"), 16);

            Location last = locations[0];

            using (var g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int index = 0; index < locations.Count; index++)
                {
                    g.DrawString(((char)(65 + index)).ToString(), font, Brushes.Red, locations[index].X, locations[index].Y);
                }

                for (int index = 0; index < locations.Count - 1; index++)
                {
                    var from = locations[index];
                    var to = locations[index + 1];

                    g.DrawLine(pen, from.X, from.Y, to.X, to.Y);
                }

                for (float percent = 0; percent < 1; percent += 0.001f)
                {
                    var point = To(locations.ToList(), percent);

                    g.DrawLine(pen, last.X, last.Y, point.X, point.Y);

                    last = point;
                }
            }
        }

        private Location To(List<Location> locations, float percent)
        {
            List<Location> temp = locations.Select(v => new Location { X = v.X, Y = v.Y }).ToList();
            while (temp.Count > 1)
            {
                for (int index = 0; index < temp.Count - 1; index++)
                {
                    var from = temp[index];
                    var to = temp[index + 1];

                    from.X = from.X + (to.X - from.X) * percent;
                    from.Y = from.Y + (to.Y - from.Y) * percent;
                }
                temp.RemoveAt(temp.Count - 1);
            }

            return temp[0];
        }
    }
}
