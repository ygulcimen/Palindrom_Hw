using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Hw
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Bir Kelime Giriniz : ");
            string kelime = Console.ReadLine();
            kelime = kelime.ToLower();
            int charLength = 2;
            string terskelime = "";
            if(kelime.Length < charLength)
            {
                Console.WriteLine("Girdiğiniz kelime az 2 karakter içermelidir.Lütfen programı baştan başlatıp geçerli bir kelime giriniz");

            }
            else
            {
                while (!kelime.Contains("q"))
                {
                    for (int i = kelime.Length - 1; i >= 0; i--)
                    {
                        terskelime += kelime[i].ToString();
                    }
                    string result = kelime == terskelime ? "Girdiğiniz kelime bir palindromdur :)" : "Girdiğiniz kelime palindrom değildir :(";
                    Console.WriteLine(result);
                    Console.Write("Bir Kelime Giriniz : ");
                    kelime = Console.ReadLine();
                    kelime = kelime.ToLower();
                    terskelime = "";
                }
            }
            
            
           
            Console.ReadLine();
        }
           
        
    }
}
