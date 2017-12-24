using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classes;

namespace ListManager
{
    public class SearchListEmptyEventArgs : System.EventArgs
    {

        public List<Object> ListEvent
        {
            get;
            private set;
        }

        public SearchListEmptyEventArgs(List<Object> list)
        {
            ListEvent = list;
        }
    }
}