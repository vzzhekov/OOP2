using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public class DoubleList <T1, T2>
        where T1 :  IDisposable, new()
        where T2: new()
    {
        private List<T1> firstList = new List<T1>();
        private List<T2> secondList = new List<T2>();

        public void Add(T1 firstValue, T2 secondValue)
        {
            firstValue.Dispose(); 
            firstList.Add(firstValue);
            secondList.Add(secondValue);
        }

        public void AddEmptyValue()
        {
            firstList.Add(new T1());
            secondList.Add(new T2());
        }
    }
}
