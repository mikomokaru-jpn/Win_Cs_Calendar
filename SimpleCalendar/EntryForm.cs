using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using static SimpleCalendar.CalendarForm;

namespace SimpleCalendar
{
    class EntryForm : Form
    {

        NumberButton[] numbers = new NumberButton[10]; //数字ボタン

        public PushNumberDelegate pushNumber;

        //コンストラクタ
        public EntryForm()
        {
            Debug.Print("Calling Constractor");

            this.ClientSize = new Size(180, 290);
            this.Text = "血圧を入力してください";     // タイトルを設定
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            Label header = new Label
            {
                Size = new Size(180, 40),
                Location = new Point(0, 0),
                Text = "xx年xx月yy日(x)",
                TextAlign = ContentAlignment.MiddleCenter,
                
            };
            header.Font = new Font(header.Font.FontFamily, 14);
            this.Controls.Add(header);

            var num7 = new NumberButton(7)
            {
                Location = new Point(80, 50),
            };
            this.Controls.Add(num7);
            var num8 = new NumberButton(8)
            {
                Location = new Point(110, 50),
            };
            this.Controls.Add(num8);
            var num9 = new NumberButton(9)
            {
                Location = new Point(140, 50),
            };
            this.Controls.Add(num9);
            var num4 = new NumberButton(4)
            {
                Location = new Point(80, 80),
            };
            this.Controls.Add(num4);
            var num5 = new NumberButton(5)
            {
                Location = new Point(110, 80),
            };
            this.Controls.Add(num5);
            var num6 = new NumberButton(6)
            {
                Location = new Point(140, 80),
            };
            this.Controls.Add(num6);
            var num1 = new NumberButton(1)
            {
                Location = new Point(80, 110),
            };
            this.Controls.Add(num1);
            var num2 = new NumberButton(2)
            {
                Location = new Point(110, 110),
            };
            this.Controls.Add(num2);
            var num3 = new NumberButton(3)
            {
                Location = new Point(140, 110),
            };
            this.Controls.Add(num3);
            var num0 = new NumberButton(0)
            {
                Location = new Point(80, 140),
            };
            this.Controls.Add(num0);
            var clear = new NumberButton(-1)
            {
                Size = new Size(28+28+2, 28),
                Location = new Point(110, 140),
            };
            this.Controls.Add(clear);

            var test = new Button()
            {
                Size = new Size(40, 20),
                Location = new Point(5, 45),
            };
            test.Click += new EventHandler(testtest);
            this.Controls.Add(test);


        }
        void testtest(object sender, EventArgs e)
        {
            pushNumber(999);
        }



    }
}
