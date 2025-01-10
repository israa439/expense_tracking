using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 10; // Default border-radius
    public Color BorderColor { get; set; } = Color.Transparent;
    public Color BackgroundColor { get; set; } = Color.CornflowerBlue;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
        path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90); 
        path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90); 
        path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90); 
        path.CloseFigure();

        this.Region = new Region(path);

        
        using (Brush brush = new SolidBrush(BackgroundColor))
        {
            e.Graphics.FillPath(brush, path);
        }

        
        if (BorderColor != Color.Transparent)
        {
            using (Pen pen = new Pen(BorderColor, 1)) 
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
