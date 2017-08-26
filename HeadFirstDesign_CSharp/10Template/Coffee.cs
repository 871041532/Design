using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Template
{
    public class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("添加糖和牛奶...");
        }

        public override void brew()
        {
            Console.WriteLine("冲泡咖啡...");
        }

        public override bool customerWantsCondiments()
        {
            string answer = getUserInput();
            if (!string.IsNullOrEmpty(answer) && answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserInput()
        {
            string answer = null;
            Console.WriteLine("咖啡是否加糖和牛奶？");
            answer = Console.ReadLine();
            return answer;
        }
    }
}
