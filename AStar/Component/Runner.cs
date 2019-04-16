using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStar.Component
{
    public partial class Runner : UserControl
    {
        public Runner()
        {
            InitializeComponent();
            this.Width = 28;
            this.Height = 28;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = CreateGraphics();
            graphics.FillRectangle(new SolidBrush(Color.Blue), 5, 5, this.Width - 10, this.Height / 2 - 5);
            graphics.FillEllipse(new SolidBrush(Color.Blue), 5, this.Height / 2, 8, 8);
            graphics.FillEllipse(new SolidBrush(Color.Blue), 15, this.Height / 2, 8, 8);
            //graphics.FillEllipse(new SolidBrush(Color.Blue), (this.Width - 16) / 2, (this.Height - 16) / 2, 14, 14);
        }
    }
}
