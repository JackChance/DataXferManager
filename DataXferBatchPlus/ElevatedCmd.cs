using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataXferBatchPlus
{
    class ElevatedCmd
    {
        public bool runElevatedCmd(string command1, string command2)
        {
            command1 = "/S /K " + command1+ " & " +command2;
            ProcessStartInfo mystart = new ProcessStartInfo("cmd.exe");
            mystart.Verb = "runas";
            mystart.Arguments = command1;
            try
            {
                Process.Start(mystart);

                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
    }
}
