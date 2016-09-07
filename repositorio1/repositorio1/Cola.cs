using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio1
{
    class Cola
    {
        private int[] elements;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public void Initialize(int size)
        {
            count = 0;
            elements = new int[size];
        }

        public Cola(int size)
        {
            count = 0;
            elements = new int[size];
        }

        public bool Queue(int newElement)
        {
            if (count < elements.Length)
            {
                elements[count++] = newElement;
                return true;
            }
            return false;
        }


        public int Dequeue()
        {
            int t = elements[0];

            for (int i = 0; i < count - 1; i++)
            {
                elements[i] = elements[i + 1];
                elements[i + 1] = 0;
            }
            count--;
            return t;
        }


        public Lista Tail()
        {
            Lista T = new Lista();

            //(count - 1);
            for (int i = 0; i < count; i++)
            {
                T.InsertLast(elements[i]);
            }
            return T;
        }

        public class Cola
        {
            public int[] elements;
            public int count;

            public void INIT(int size)
            {
                elements = new int[size];
                count = 0;
            }
        }

        public bool que(int e)
        {
            if (count < elements.Length)
            {
                elements[count] = 2;
                count++;
                return e;
            }
            return false;
        }

        
    }
}
