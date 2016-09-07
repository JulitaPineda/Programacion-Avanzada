﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista myList = new Lista();
            myList.Initialize(10);
            myList.InsertFirst(40);
            myList.InsertLast(12);
            Console.ReadLine();

            /*Prueba de Implementación de Listas*/
            Lista myList = new Lista();
            myList.Initialize(10);
            myList.InsertFirst(40);
            myList.InsertFirst(20);
            myList.InsertLast(12);

            /*Prueba de Implementación de Colas*/
            Cola myCola = new Cola();
            myCola.Initialize(10);
            myCola.Queue(5);
            myCola.Queue(3);
            myCola.Queue(7);
            myCola.Dequeue();
            myCola.Dequeue();
            myCola.Dequeue();
            myCola.Queue(15);
            Console.ReadLine();
        }

        
    }
}
