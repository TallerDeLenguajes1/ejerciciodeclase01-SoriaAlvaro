using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try{
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }catch(OverflowException ex){
                System.Console.WriteLine("\nEl valor era demasiado grande o demasiado pequeño para el tipo byte.\n   El tipo byte representa un entero sin signo de 0 a 255.");
            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
