using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Expense_Tracking_App.CustomControls
{
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20;
        public Color ForeColor1 { get => base.ForeColor; set { base.ForeColor = value;this.ForeColor1 = value;this.Invalidate(); } }

       

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            GraphicsPath path = new GraphicsPath();
            int arcSize = BorderRadius * 2;

            path.AddArc(0, 0, arcSize, arcSize, 180, 90); // Top-left
            path.AddArc(Width - arcSize, 0, arcSize, arcSize, 270, 90); // Top-right
            path.AddArc(Width - arcSize, Height - arcSize, arcSize, arcSize, 0, 90); // Bottom-right
            path.AddArc(0, Height - arcSize, arcSize, arcSize, 90, 90); // Bottom-left
            path.CloseFigure();

            this.Region = new Region(path);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Fill the button background
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            // Draw the button text
            TextRenderer.DrawText(
                pevent.Graphics,
                this.Text,
                this.Font,
                ClientRectangle,
                this.ForeColor, 
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

    }
}
