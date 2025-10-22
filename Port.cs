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
                var hour = since.Hour.ToString("D2");
                var minute = since.Minute.ToString("D2");
                return new ListViewItem(new[] { name, $"{hour}:{minute}" });
            }
        }
    }
}
