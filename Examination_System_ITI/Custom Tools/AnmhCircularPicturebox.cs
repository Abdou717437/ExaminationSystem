using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace Responsive_Design
{
    public class AnmhCircularPictureBox : PictureBox
    {
        //Fields
        private int borderSize = 2;
        private Color borderColor1 = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderDashStyle = DashStyle.Solid;
        private DashCap borderCap = DashCap.Flat;
        private float gradientAngle = 50F;

        //Constructor

        public AnmhCircularPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Properties
        [Category("Anmh Custom Properties")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }
        [Category("Anmh Custom Properties")]
        public Color BorderColor1
        {
            get => borderColor1;
            set { borderColor1 = value; this.Invalidate(); }
        }
        [Category("Anmh Custom Properties")]
        public Color BorderColor2
        {
            get => borderColor2;
            set { borderColor2 = value; this.Invalidate(); }
        }
        [Category("Anmh Custom Properties")]
        public DashStyle BorderDashStyle
        {
            get => borderDashStyle;
            set { borderDashStyle = value; this.Invalidate(); }
        }
        [Category("Anmh Custom Properties")]
        public DashCap BorderCap
        {
            get => borderCap;
            set { borderCap = value; this.Invalidate(); }
        }
        [Category("Anmh Custom Properties")]
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            var graph = pe.Graphics;
            var rectCounterSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectCounterSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, BorderColor1, BorderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                penBorder.DashStyle = borderDashStyle;
                penBorder.DashCap = borderCap;
                pathRegion.AddEllipse(rectCounterSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                //Drawing 
                graph.DrawEllipse(penSmooth, rectCounterSmooth);
                if (BorderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);

            }

        }
    }
}

