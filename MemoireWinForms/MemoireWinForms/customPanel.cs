using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace MemoireWinForms
{

    public class GradientRoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 22;

        public Color ColorStart { get; set; } = Color.FromArgb(62,62,62);
        public Color ColorEnd { get; set; } = Color.FromArgb(62, 62, 62);

        public GradientRoundedPanel()
        {
            this.DoubleBuffered = true;
            this.Resize += (s, e) => this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = RoundedRect(this.ClientRectangle, BorderRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, ColorStart, ColorEnd, LinearGradientMode.Vertical))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.Left, bounds.Top, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Top, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
    }


}
