using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWindowsApplication
{
    public class command
    {
        public string name { get; set; }
        public List<type> types { get; set; }
    }

    public class type
    {
        public commandType variant { get; set; }
        public List<parameter> parameters { get; set; }
        public string description { get; set; }
    }

    public class parameter
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public enum commandType { Test, Query, Set, Execute };
}
