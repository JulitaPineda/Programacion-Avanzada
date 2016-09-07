using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio1
{
    class EjerciciosRecursividad
    {
        //Sucesion de fibonacci
        public int Fibo(int N)
        {
            if(N==1)
            {
                return 0;
            }
            if (N == 2)
            {
                return 1;
            }
            return Fibo(N - 2) + Fibo(N - 1);
        }

        //
        public String inv (string s)
        {
            string input = "substring";
            if (s.Length == 1)
            {
                return s;
            }
            else
            {
                string sub = input.Substring(inv(s, 0, s.Length - 2));

                return s[s.Length - 1] + sub; 
            }
        }
    }
}
