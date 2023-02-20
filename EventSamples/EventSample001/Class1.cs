using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample001
{
    public class MyClass
    {
        public event EventHandler XChanged;

        private void OnXChange()
        {
            if (XChanged != null)
            {
                XChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private int _x;
        public int x
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OnXChange();
                }
            }
        }
    }

    // set (int vaule)
}
