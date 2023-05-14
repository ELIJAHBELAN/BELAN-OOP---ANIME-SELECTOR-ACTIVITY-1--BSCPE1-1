//Elijah Zachary A. Belan
//BSCPE 1-1
//WELCOME TO ANIME SELECTOR
using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Welcome to Anime Selector");
        Console.WriteLine();

        bool selectAnotherGenre = true;

        while (selectAnotherGenre)
        {
            Console.WriteLine("Select Your Preferred Genre");
            Console.WriteLine();
            Console.WriteLine("Select 1 to watch Shounen");
            Console.WriteLine("Select 2 to watch Isekai");
            Console.WriteLine("Select 3 to watch Sports");
            Console.WriteLine("Select 4 to watch Rom Com");
            Console.WriteLine();

            Console.Write("Enter Genre: ");
            int choiceNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Genre You Selected is: " + choiceNum);
            if (choiceNum == 1)
            {
                Console.WriteLine("Shounen");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Shounen Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("Hunter x Hunter");
                Console.WriteLine("One Piece");
                Console.WriteLine("Naruto");
                Console.WriteLine();

                Console.Write("Would you like to pick another genre? (yes/no): ");
                string pickAnotherGenre = Console.ReadLine();

                if (pickAnotherGenre.ToLower() != "yes")
                    selectAnotherGenre = false;
                Console.WriteLine();

            }
            else if (choiceNum == 2)
            {
                Console.WriteLine("Isekai");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Isekai Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("Dr. Stone");
                Console.WriteLine("Mushoku Tensei");
                Console.WriteLine("That Time I Got Reincarnated As A Slime");
                Console.WriteLine();

                Console.Write("Would you like to pick another genre? (yes/no): ");
                string pickAnotherGenre = Console.ReadLine();

                if (pickAnotherGenre.ToLower() != "yes")
                    selectAnotherGenre = false;
                Console.WriteLine();

            }
            else if (choiceNum == 3)
            {
                Console.WriteLine("Sports");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Sports Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("Haikyu!");
                Console.WriteLine("Kuroko No Basket");
                Console.WriteLine("Blue Lock");
                Console.WriteLine();

                Console.Write("Would you like to pick another genre? (yes/no): ");
                string pickAnotherGenre = Console.ReadLine();

                if (pickAnotherGenre.ToLower() != "yes")
                    selectAnotherGenre = false;
                Console.WriteLine();
            }
            else if (choiceNum == 4)
            {
                Console.WriteLine("Rom Com");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Rom Com Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("Kaguya-Sama Love Is War");
                Console.WriteLine("Horimiya");
                Console.WriteLine("Fruit Basket");
                Console.WriteLine();

                Console.Write("Would you like to pick another genre? (yes/no): ");
                string pickAnotherGenre = Console.ReadLine();

                if (pickAnotherGenre.ToLower() != "yes")
                    selectAnotherGenre = false;
                Console.WriteLine();
            }
            Console.WriteLine("Thank you for using anime selector!<3");
            Console.WriteLine();
        }
    }


}
