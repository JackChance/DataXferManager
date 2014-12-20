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
            command1 = "echo /S /K " + command1;
            //check to see if this is just a test, i.e. has the string '/q '
            bool skipcom2a = false;
            bool skipcom2b = false;
            string c;
            foreach(char b in command1)
            {
                c = b.ToString();
                //stop checking if they are both true.
                if(!skipcom2b || !skipcom2a)
                {
                    if (c == "/")
                    {
                        //if this is a / then set hook one to true
                        skipcom2a = true;
                    } else
                    if(c == "l" && skipcom2a)
                    {
                        //if hook one is true and this is l then set hook two to true ("/l" is the switch for test copy.)
                        skipcom2b = true;
                    }
                    if(c != "/" && c !="l" && c!= " ")
                    {
                        // if this isn't a /, l or space then reset both hooks to false, it means the string was "/l"+x, where x is anything invalid for the "/l" switch
                        skipcom2a = false;
                        skipcom2b = false;
                    }
                }
            }
            if(skipcom2a && skipcom2b)
            {
               //do nothing if both hooks are true
            }
            else
            {
                //If both aren't true then remove the system and hidden tags from the result folder, just in case.
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
