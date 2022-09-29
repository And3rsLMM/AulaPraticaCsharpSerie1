using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPraticaCsharpSerie1.Entities;
using AulaPraticaCsharpSerie1.Functions;

namespace AulaPraticaCsharpSerie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Senai senai = new Senai();
            UserSenai userSenai = new UserSenai();
            AverageGrade grade = new AverageGrade();
            Number num = new Number();

            senai.WelcomeMessage();

            userSenai.NomeInPut();
            userSenai.NomeOutPut();
            
            grade.DigitaNota();
            grade.CalculaNota();
                        
            num.NumberInPut();
            num.NumberOutPut();
            num.MoreLessNumberOutPut();
        }
    }
}
