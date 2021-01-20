using System;
using System.Collections.Generic;
using System.Text;

namespace CenericsIntro
{
    class MyList<T>//BEN MYLİSTİMDE T İLE ÇALIŞACAĞIM.
    {
        T[] items;
        //constructor aşağıda ki bloğun adı 
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        {
            T[] tempArray = items; //geçiciarray 
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
