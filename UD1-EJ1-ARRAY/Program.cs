using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ1_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            String[] people = new String[3];
            int count = 0;

            while (count < people.Length)
            {
                Console.WriteLine($"Escribe la palabra numero: {count+1}");
                people[count] = Console.ReadLine();
                count++;
            }

            //Mostramos los datos 
            foreach (String i in people) {
                Console.WriteLine(i);
            }
        } 
    }
}
