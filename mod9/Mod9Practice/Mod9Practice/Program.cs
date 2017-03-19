using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mod9Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            videoRecorder vR = new videoRecorder();
            outbox ob = new outbox();

            vR.fireMessage += ob.emailMessage;
            vR.fireMessage += ob.SMSMessage;
            Console.WriteLine("Full set of messenger services.");
            vR.videoRecord();

            vR.removeEmailHandler(ob);
            Console.WriteLine("Removed email messenger services.");
            vR.videoRecord();

            vR.addEmailHandler(ob);
            Console.WriteLine("Removed email messenger services.");
            vR.videoRecord();
            Console.ReadLine();
        }
    }
}
