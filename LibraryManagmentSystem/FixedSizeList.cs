using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSessionAdv_1
{
    internal class FixedSizeList<T>
    {
         int FixedCapacity;
         List<T> list;
        public FixedSizeList(int fixedCapacity)
        {
            FixedCapacity= fixedCapacity;
            list=new List<T>(fixedCapacity);
            
        }
        public void Add(T element)
        {
            if(list.Count==FixedCapacity) 
                throw new InvalidOperationException("there are not found places in the list it's full");
            else list.Add(element);
        }
        public T Get(int index)
        {
            if(index>=FixedCapacity) throw new InvalidOperationException("the index is invalid");
            return list[index];
        }

    }
}
