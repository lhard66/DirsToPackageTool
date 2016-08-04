using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirsToPackageTool
{
    //观察者模式
    //public delegate void LogMsgMethod(string strMsg);
    
    
    public class ObsolotorLogMsg
    {              
        //使用泛型委托
        
        public static event Action<string> logMsgEvent;
        //public static event LogMsgMethod msgHandler;
        public static void CallMsgHandler(string strMsg)
        {
            if (logMsgEvent != null)
            {
                logMsgEvent(strMsg);
            }
        }
    }
}
