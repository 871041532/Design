using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
    //调用者持有一个命令对象并在某个时间点调用excute()方法
    public abstract class Invoker
    {
        public abstract void setCommand();
    }
}
