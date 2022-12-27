using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Calculate : ISum
    {
        ILogger Logger { get; }
        public Calculate(ILogger logger)
        {
            Logger = logger;
        }
        int ISum.Sum(int a, int b)
        {
            Logger.Event("Ваш результат");//событие синим цветом
            return a + b;
        }
    }
}
