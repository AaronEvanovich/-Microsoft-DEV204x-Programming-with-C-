using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mod9Practice
{
    class videoRecorder
    {
        public delegate void messenger(object source, EventArgs e);
        public event messenger fireMessage;
        public void videoRecord()
        {
            Console.WriteLine("Video recording has started...");
            Thread.Sleep(3000);
            OnRecordingCompleted();
            
        }
        public void OnRecordingCompleted()
        {
            if (fireMessage != null)
            {
                fireMessage(this, EventArgs.Empty);
            }
        }
        public void addEmailHandler(outbox ob)
        {
            this.fireMessage += ob.emailMessage;
        }
        public void removeEmailHandler(outbox ob)
        {
            this.fireMessage -= ob.emailMessage;
        }
    }
}
