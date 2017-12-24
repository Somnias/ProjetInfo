using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Activité
    {
        ///
        ///
        ///
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public Activité(string descriptiontmp, int idtmp)
        {
            Id = idtmp;
            Description = descriptiontmp;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}",Id,Description);
        }
    }
}
