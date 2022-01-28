using System;

namespace Module_5
{
    class Program
    {

       static (string name, string surname, int Age, bool Pet) UserData() 
        {
            (string Name, string Surname, int Age, bool Pet) anketa;

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

            string petstr;
            int petnum;

            Console.WriteLine("Do you have pets (Yes/No): ");
            petstr = Console.ReadLine();

            if (petstr == "Yes")
            {
                anketa.Pet = true;
                Console.WriteLine("How much pets do you have");
                petnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter nicknames");
                CreateArrayPets(petnum);
            }
            else 
            {
                anketa.Pet = false;
            }
            return anketa;

        }

        static string[] CreateArrayPets(int num) 
        {
            var pets = new string[num];

            for (int i = 0; i < num; i++)
            {
                pets[i] = Console.ReadLine();
            }

            return pets;
        }



              
        static bool DataChek(string number, out int corrnumber) 
        {
            if (int.TryParse(number, out int intnum)) 
            {
                if (intnum > 0) 
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            
            {
                corrnumber = 0;
                return true;
            }
        }



        static void Main(string[] args)
        {
         
            
            
            UserData();
            Console.ReadKey();
            
        }
    }
}
