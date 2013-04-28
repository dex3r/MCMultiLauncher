using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MultiLauncher
{
    public enum Systems
    {
        Windows = 1,
        Linux,
        Mac,
    }

    public abstract class SystemDetection
    {
        private static Systems system = 0;
        public static Systems System
        {
            get 
            {
                if (system == 0)
                {
                    checkOutSystem();
                }
                return system; 
            }
            set { system = value; }
        }

        public static void checkOutSystem()
        {
            string sys = Environment.OSVersion.VersionString;
            sys = sys.ToLower();
            if(sys.Contains("windows"))
            {
                system = Systems.Windows;
            }
            else if (sys.Contains("linux"))
            {
                system = Systems.Linux;
            }
            else if (sys.Contains("mac"))
            {
                system = Systems.Mac;
            }
            else
            {
                MessageBox.Show("Can't recognize operation system:\n" + sys, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (system != 0)
            {
#if DEBUG
                //MessageBox.Show("Your operating system is:\n" + system, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            }
            else
            {
                system = Systems.Linux;
            }
        }
    }
}
