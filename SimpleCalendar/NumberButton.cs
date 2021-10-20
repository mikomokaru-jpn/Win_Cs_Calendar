using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleCalendar
{
    class NumberButton : Control
    {
        int number = 0;
        Pen pen = new Pen(Color.Gray, 2);

        public NumberButton(int num)
        {
            number = num;
            BackColor = Color.White;
            Size = new Size(28, 28);
            Font = new Font(SystemFonts.DefaultFont.FontFamily, 12);


            

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(pen, 0, 0, Width, Height);


            String text = number.ToString();
            if (number < 0)
            {
                text = "C";
            }
            
            Size textSize = TextRenderer.MeasureText(text, Font);
            Point point = new Point((Width / 2) - (textSize.Width / 2) + 1,
                                    (Height / 2) - (textSize.Height / 2) - 1);
            e.Graphics.DrawString(text, Font, Brushes.Black, point.X, point.Y);
        }
    }
}
