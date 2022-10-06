using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Responsive_Design.Anmh_Controls
{
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }
    public class AnmhProgressBar : ProgressBar
    {
        //Fields
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximum = false;

        //Others
        private bool paintedBack = false;
        private bool stopPainting = false;

        //Constructor
        public AnmhProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }

        //Properties
        [Category ("Anmh Custom Properties")]
        public Color ChannelColor 
        {
            get => channelColor;
            set
            {
                channelColor = value;
                this.Invalidate();
            }
        }
        [Category("Anmh Custom Properties")]
        public Color SliderColor 
        {
            get => sliderColor;
            set
            {
                sliderColor = value;
                this.Invalidate();
            }
        }
        [Category("Anmh Custom Properties")]
        public Color ForeBackColor 
        { 
            get => foreBackColor;
            set
            {
                foreBackColor = value;
                this.Invalidate();
            }
        }
        [Category("Anmh Custom Properties")]
        public int ChannelHeight 
        {
            get => channelHeight;
            set
            {
                channelHeight = value;
                this.Invalidate();
            }
        }
        [Category("Anmh Custom Properties")]
        public int SliderHeight 
        { 
            get => sliderHeight;
            set
            {
                sliderHeight = value;
                this.Invalidate();
            }
        }
        [Category("Anmh Custom Properties")]
        public TextPosition ShowValue 
        { 
            get => showValue;
            set
            {
                showValue = value;
                this.Invalidate();
            }
        }

        [Category("Anmh Custom Properties")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font 
        {
            get => base.Font;
            set => base.Font = value; 
        }

        [Category("Anmh Custom Properties")]
        public override Color ForeColor 
        {
            get => base.ForeColor; 
            set => base.ForeColor = value; 
        }
        public string SymbolBefore 
        {
            get => symbolBefore;
            set 
            {
                symbolBefore = value;
                this.Invalidate();
            }
        }
        public string SymbolAfter 
        {
            get => symbolAfter;
            set
            {
                symbolAfter = value;
                this.Invalidate();
            }
        }
        public bool ShowMaximum 
        {
            get => showMaximum;
            set
            {
                showMaximum = value;
                this.Invalidate();
            }
        }


        //->Paint the Background and Channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if(stopPainting == false)
            {
                if(paintedBack == false)
                {
                    //Fields
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, channelHeight);
                    using ( var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = this.Height - channelHeight;
                        else rectChannel.Y = this.Height - ((channelHeight + sliderHeight) / 2);
                        //Painting 
                        graph.Clear(this.Parent.BackColor); //Surface
                        graph.FillRectangle(brushChannel, rectChannel); //Channel
                        //Stop Painting the Background and Channel
                        if(this.DesignMode == false)
                            paintedBack = true;
                    }
                }
                //Reset Paintaing
                if (this.Value == this.Maximum || this.Value == this.Minimum)
                    paintedBack = false;
            }
        }
        //Paint Slider
        protected override void OnPaint(PaintEventArgs e)
        {
            if(stopPainting == false)
            {
                //Fields
                Graphics graph = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                        rectSlider.Y = this.Height - sliderHeight;
                    else rectSlider.Y = this.Height - ((sliderHeight + channelHeight) / 2);

                    //Painting
                    if(sliderWidth > 1) //Slider
                        graph.FillRectangle(brushSlider, rectSlider);
                    if (showValue != TextPosition.None) //Text
                        DrawValueText(graph, sliderWidth, rectSlider);
                }
            }
            if (this.Value == this.Maximum) stopPainting = true; //Stop Painting
            else stopPainting = false; //Keep Painting
        }

        //-> Paint Value Text
        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            //Fields
            string text = symbolBefore + this.Value.ToString() + symbolAfter;
            if(showMaximum) text = text + "/" + symbolBefore + this.Maximum.ToString() + symbolAfter;
            var textSize = TextRenderer.MeasureText(text, this.Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
            using (var brushText = new SolidBrush(this.ForeColor))
            using (var brushTextBack = new SolidBrush(foreBackColor))
            using (var textFormat = new StringFormat())
            {
                switch(showValue)
                {
                    case TextPosition.Left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                    break;
                    case TextPosition.Right:
                        rectText.X = this.Width - textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                    break;
                    case TextPosition.Center:
                        rectText.X = (this.Width - textSize.Width) / 2;
                        textFormat.Alignment = StringAlignment.Center;
                    break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        //Clean Previous Text Surface
                        using (var brushClear = new SolidBrush(this.Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            graph.FillRectangle(brushClear, rect);
                        }
                        break;
                }
                //Painting 
                graph.FillRectangle(brushTextBack, rectText);
                graph.DrawString(text, this.Font, brushText, rectText, textFormat);
            }
        }
    }
}
