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
            command1 = "/S /K " + command1;
            //check to see if this is just a test, i.e. has the string '/q '
            bool skipcom2a = false;
            bool skipcom2b = false;
            string c;
            foreach(char b in command1)
            {
                c = b.ToString();
                //stop checking if they are both true.
                if(!skipcom2b)
                {
                if (c == "/" && skipcom2a ==false)
                {
                    skipcom2a = true;
                }else 
                    if(c == "q" && skipcom2a == true)
                    {
                        skipcom2b = true;
                    }else
                        if(c == " " && skipcom2b == true)
                        {
                            
                        }
                        else
                        {
                            skipcom2a = false;
                            skipcom2b = false;
                        }
                }
            }
            if(!skipcom2a || !skipcom2b)
            {
               
            }
            else
            {
                command1 += " & " + command2;
            }
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
