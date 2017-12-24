using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManager
{
    public class ListActivité
    {








        public event EventHandler<SearchListEmptyEventArgs> SearchListEmpty;
        private void OnSearchListEmpty(SearchListEmptyEventArgs args)
        {
            if (SearchListEmpty != null)
            {
                SearchListEmpty(this, args);
            }
        }
    }
}
