using System;
using AulaPraticaCsharpSerie1.Entities;

namespace AulaPraticaCsharpSerie1.Functions
{
    public class AverageGrade
    {
        double[] Nota = new double[3];
        double Media { get; set; }
        double Soma { get; set; }
        public void DigitaNota()
        {
            for (int i = 0; i < Nota.Length; i++)
            {               
                Console.WriteLine($"Por favor, digite sua {i+1}ºnota: ");
                Nota[i] = double.Parse(Console.ReadLine());
                Soma += Nota[i];
            }
            Console.WriteLine(Soma);
        }

        public void CalculaNota()
        {
            double Media = Soma / 3;
            if (Media > 6)
            {
                Console.WriteLine($"Parabens, sua média é {Media} e você está aprovado");
            }
            else
            {
                Console.WriteLine($"Que pena, sua média é {Media} e você está reprovado");
            }
        }
    }
}