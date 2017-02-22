using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    class Coffee
    {
        int scale;
        string type;
        string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        
        public Coffee(int scale, string type, string country)
        {
            this.scale = scale;
            this.type = type;
            this.country = country;
        }
    }
}
