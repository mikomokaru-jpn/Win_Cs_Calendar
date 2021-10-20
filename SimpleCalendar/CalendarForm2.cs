using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalendar
{
    public partial class CalendarForm
    {

        public delegate void PushNumberDelegate();

        public void item_DoubleClick(object sender, EventArgs e)
        {
            
            entryForm.ShowDialog();
        }

    }
}
