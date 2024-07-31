using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class CircularProgressbar : UserControl
    {
        private int progress;
        private int thickness;
        private Color progressColor = Color.Blue;
        private Color backgroundColor = Color.Gray;
        private Color textColor;
        private Font textFont;
        private bool showText;

        public CircularProgressbar()
        {
            this.DoubleBuffered = true;
            this.progress = 0;
            this.thickness = 10;
            this.progressColor = Color.Blue;
            this.backgroundColor = Color.Gray;
            this.textColor = Color.White;
            this.textFont = this.Font;
            this.showText = true;
            this.Resize += new EventHandler(CircularProgressBar_Resize);
        }

        [Description("Gets or sets the progress of the circular progress bar."), Category("Appearance")]
        public int Progress
        {
            get { return progress; }
            set { progress = value; this.Invalidate(); }
        }

        [Description("Gets or sets the thickness of the progress bar."), Category("Appearance")]
        public int Thickness
        {
            get { return thickness; }
            set { thickness = value; this.Invalidate(); }
        }

        [Description("Gets or sets the color of the progress."), Category("Appearance")]
        public Color ProgressColor
        {
            get { return progressColor; }
            set { progressColor = value; this.Invalidate(); }
        }

        [Description("Gets or sets the background color of the progress bar."), Category("Appearance")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; this.Invalidate(); }
        }

        [Description("Gets or sets the color of the text."), Category("Appearance")]
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; this.Invalidate(); }
        }

        [Description("Gets or sets the font of the text."), Category("Appearance")]
        public Font TextFont
        {
            get { return textFont; }
            set { textFont = value; this.Invalidate(); }
        }

        [Description("Gets or sets whether to show the progress text."), Category("Appearance")]
        public bool ShowText
        {
            get { return showText; }
            set { showText = value; this.Invalidate(); }
        }

        private void CircularProgressBar_Resize(object sender, EventArgs e)
        {
            this.Width = this.Height;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle innerRect = new Rectangle(thickness, thickness, this.Width - thickness * 2, this.Height - thickness * 2);

            using (Pen pen = new Pen(backgroundColor, thickness))
            {
                e.Graphics.DrawEllipse(pen, innerRect);
            }

            using (Pen pen = new Pen(progressColor, thickness))
            {
                float sweepAngle = 360f * progress / 100;
                e.Graphics.DrawArc(pen, innerRect, -90, sweepAngle);
            }

            if (showText)
            {
                string percentage = $"{progress}%";
                SizeF textSize = e.Graphics.MeasureString(percentage, textFont);
                PointF textPosition = new PointF(
                    (this.Width - textSize.Width) / 2,
                    (this.Height - textSize.Height) / 2);

                using (Brush textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(percentage, textFont, textBrush, textPosition);
                }
            }
        }

    }
}
