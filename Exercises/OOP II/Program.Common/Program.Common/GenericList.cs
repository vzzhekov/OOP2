using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
   public class GenericList<T>
    
   {
       const int DefaultCapacity = 12; 
       private T[] elements;
       private int count = 0;

       public GenericList(int capacity)
       {
           elements = new T[capacity];
       }
       public GenericList()
           : this(DefaultCapacity)
       {
       }
       public void Add(T input)
       {
           if (count >= elements.Length)
           {
               throw new IndexOutOfRangeException(String.Format("The list capacity of {0} was exceeded with {1} elements in the list!",count, elements.Length));
           }
           this.elements[count] = input;
           count++; 
       }

       public int Count
       {
           get
           {
               return this.count; 
           }
       }

       public T this[int index]
       {
           get
           {
               if (index >= count)
               {
                   throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", index));
               }
               T result = elements[index];
               return result; 
           }
       } 

    }
}
