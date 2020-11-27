using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLab4
{
    class TeamsJournalEntry
    {
        public string CollectionName { get; set; }
        public string CollectionEvent { get; set; }
        public int NumberOfEl;
        public TeamsJournalEntry( string Name, string Ev, int numOfEl) {

            CollectionName = Name;
            CollectionEvent = Ev;
            NumberOfEl = numOfEl;
        }
        public override string ToString()
        {
            return string.Format("Collection name: {0} \n Event: {1} \n Number of el {2} \n",this.CollectionName,this.CollectionEvent,this.NumberOfEl);
        }
    }
}
