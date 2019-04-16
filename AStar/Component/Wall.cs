using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AStar.Base;

namespace AStar.Component
{
    public partial class Wall : UserControl
    {
        public Wall()
        {
            InitializeComponent();

            this.Width = 28;
            this.Height = 28;
        }

        public void ChangeSize(int size)
        {
            this.Height = this.Width = size;
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = CreateGraphics();
            graphics.FillRectangle(new SolidBrush(Color.DarkGray), 1, 1, Width - 1, Height - 1);
        }

        public bool Contains(Vector2 position)
        {
            bool ret = false;
            ret = (position.x >= Location.X && position.x <= Location.X + Width) && (position.y >= Location.Y && position.y <= Location.Y + Height);
            return ret;
        }
    }
}
