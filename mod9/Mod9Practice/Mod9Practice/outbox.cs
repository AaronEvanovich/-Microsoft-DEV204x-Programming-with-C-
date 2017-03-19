using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9Practice
{
    class outbox
    {
            public void emailMessage(object s, EventArgs e) //event handler method
            {
                Console.WriteLine("Recording has been completed. This is sent through email.");
            }
            public void SMSMessage(object s, EventArgs e) //event handler method
            {
                Console.WriteLine("Recording has been completed. This is sent through SMS.");
            }
    }
}
