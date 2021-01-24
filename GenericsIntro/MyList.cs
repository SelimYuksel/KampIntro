using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<Type>
    {
        Type[] items;

        //ctor tab tab = constructor
        public MyList()
        {
            items = new Type[0];
        }
         
        public void Add(Type item)
        {
            Type[] tempArray = items;
            items = new Type[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
