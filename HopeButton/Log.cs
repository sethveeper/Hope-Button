using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeButton
{

    class Log
    {
        private string logName;
        private string logDescrip;
        private int logNumber;

        public string LogName { get => logName; set => logName = value; }
        public string LogDescrip { get => logDescrip; set => logDescrip = value; }
        public int LogNumber { get => logNumber; set => logNumber = value; }


        public Log(string inName, string inDescrip, int inNumber)
        {
            logName = inName;
            logDescrip = inDescrip;
            logNumber = inNumber;
        }
        public Log(string inName, string inDescrip)
        {
            logName = inName;
            logDescrip = inDescrip;
            logNumber = 0;
        }

        public Log()
        {
            logName = "Generic Log";
            logDescrip = "It's Just Another Day...";
            logNumber = 0;
        }

        public override string ToString()
        {
            return logName;
        }
    }
}
