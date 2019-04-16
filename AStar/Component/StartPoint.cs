using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AStar.Component
{
    public partial class StartPoint : UserControl
    {
        public StartPoint()
        {
            InitializeComponent();
            this.Width = 28;
            this.Height = 28;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(new SolidBrush(Color.Blue), (this.Width - 16) / 2, (this.Height - 16) / 2, 14, 14);
            //graphics.DrawEllipse(new Pen(Color.Blue), (this.Width - 20) / 2, (this.Height - 20) / 2, 18, 18);
        }
    }
}
