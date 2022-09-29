using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPraticaCsharpSerie1.Entities
{
    public class Number
    {
        public int VarNumber { get; set; }
        public void NumberInPut()
        {
            Console.WriteLine("Por favor, digite um numero: ");
            VarNumber = int.Parse(Console.ReadLine());
        }
        public void NumberOutPut()
        {
            Console.WriteLine($"O numero digitado foi {VarNumber} e seu tipo é {VarNumber.GetType()}");
        }
        public void MoreLessNumberOutPut()
        {
            Console.WriteLine($"O numero digitado foi {VarNumber} e seu sucessor é {VarNumber + 1} e seu antecessor é {VarNumber - 1}");
        }

    }
    
}
