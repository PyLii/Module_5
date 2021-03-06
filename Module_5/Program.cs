using System;

namespace Module_5
{
    class Program
    {

       static (string Name, string Surname, int Age, bool Pet, int Favcolors) UserData() 
        {
            (string Name, string Surname, int Age, bool Pet, int Favcolors) anketa;

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


            int colornum;
            

            Console.WriteLine("Enter the number of favorite colors ");
            colornum = Convert.ToInt32(Console.ReadLine());

            if (colornum > 0)
            {
                ColorName(colornum);
            }
            else 
            {
                Console.WriteLine("It's sad");
                
            }
            anketa.Favcolors = colornum;


            return anketa;

        }

   
        static string[] ColorName(int colornum)
        {
            var colors = new string[colornum];

            for (int i = 0; i < colornum; i++)
            {
                colors[i] = Console.ReadLine();
            }

            return colors;
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

        static void Output() 
        {
            var (Name, Surname, Age, Pet, Favcolors) = UserData();
            
            Console.WriteLine("Result Output");
            Console.WriteLine($"Your name is {Name}, your Surname is {Surname} and your age is {Age}.");

            
            if (Pet == true)
            {
                Console.WriteLine("You have a pet");
            }
            else
            {
                Console.WriteLine("You don't have a pet");
            }

            Console.WriteLine($"Your number of favorite color(s) {Favcolors}");
            

        }


        static void Main(string[] args)
        {

            Output();
                
            Console.ReadKey();
            
        }
    }
}
