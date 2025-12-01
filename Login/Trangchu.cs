using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Login
{
    public class CustomButton : Button
    {
   
        private int borderRadius = 20;
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

      
        private Color hoverColor = Color.FromArgb(52, 152, 219);
        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value; }
        }

    
        private Color originalColor;

        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(41, 128, 185);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            originalColor = this.BackColor;

            this.MouseEnter += CustomButton_MouseEnter;
            this.MouseLeave += CustomButton_MouseLeave;
        }

        private void CustomButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = hoverColor;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = originalColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Bo góc
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }
    }
}
