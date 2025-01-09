using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Expense_Tracking_App.CustomControls
{
    public class BorderedGroupBox : GroupBox
    {
        public int BorderRadius { get; set; } = 20;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a path for the rounded rectangle
            GraphicsPath path = new GraphicsPath();
            int arcSize = BorderRadius * 2;

            path.AddArc(0, 0, arcSize, arcSize, 180, 90); // Top-left
            path.AddArc(Width - arcSize - 1, 0, arcSize, arcSize, 270, 90); // Top-right
            path.AddArc(Width - arcSize - 1, Height - arcSize - 1, arcSize, arcSize, 0, 90); // Bottom-right
            path.AddArc(0, Height - arcSize - 1, arcSize, arcSize, 90, 90); // Bottom-left
            path.CloseAllFigures();

            // Clip the control to the rounded shape
            this.Region = new Region(path);

            // Draw the border
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Fill the background with the desired color
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            //using (Pen pen = new Pen(Color.Black, 2))
            //{
            //    e.Graphics.DrawPath(pen, path);
            //}
        }
    }
}
