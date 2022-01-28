using System;

namespace Module_5
{
    class Program
    {

       static (string name, string surname, int Age, string Pet) UserData() 
        {
            (string Name, string Surname, int Age, string Pet) anketa;

            Console.WriteLine("Enter your name: ");
            anketa.Name = Console.ReadLine();

            Console.WriteLine("Enter your Surname: ");
            anketa.Surname = Console.ReadLine();

            string agestr;
            int ageint;

            do
            {
                Console.WriteLine("Enter your age in numbers: ");
                agestr = Console.ReadLine();
            } while (DataChek(agestr, out ageint));

            anketa.Age = ageint;
            
            Console.WriteLine("Do you have pets (Yes/No): ");
            anketa.Pet = Console.ReadLine();

           
            return anketa;

        }

              
        static bool DataChek(string number, out int corrnumber) 
        {
            if (int.TryParse(number, out int intnum)) 
            {
                if (intnum > 0) 
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            
            {
                corrnumber = 0;
                return false;
            }
        }



        static void Main(string[] args)
        {
         
            
            
            UserData();
            Console.ReadKey();
            
        }
    }
}
