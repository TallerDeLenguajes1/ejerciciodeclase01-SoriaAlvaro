﻿using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            try{Console.WriteLine("{0} - {1} - {2}", a, b);}
            catch(FormatException ex){
                System.Console.WriteLine("El índice (basado en cero) debe ser mayor o igual a cero y menor que el tamaño de la lista de argumentos.");
            }
            Console.ReadLine();
        }
    }
}
