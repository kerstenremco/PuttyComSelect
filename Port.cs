using System;
using System.Windows.Forms;

namespace PuttyComSelect
{
    
    internal class Port
    {
        public readonly string name;
        public readonly DateTime since;
        public Port(string name)
        {
            this.name = name;
            this.since = DateTime.Now;
        }
        public ListViewItem PortView
        {
            get
            {
                return new ListViewItem(new[] { name, $"{since.Hour}:{since.Minute}" });
            }
        }
    }
}
