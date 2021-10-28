using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add a starting mode, so a user can select whether to randomly generate a creature or create one manually.
            Console.WriteLine("Create a creature manually or randomly? (MANUAL/RANDOM) ");
            string userChoice = Console.ReadLine().ToLower();

            if(userChoice == "manual")
            {
                UserCreate();
            } else
            {
                Console.WriteLine("\nCreating random creature ... ");
                RandomMode();
            }

        }

        //Recreate this program so that rather than outputting a creature immediately,
        //it prompts a user to select which parts of each creature to use to build a new creature.

        static void UserCreate()
        {
            Console.WriteLine("Choose a head: (GHOST/BUG/MONSTER) ");
            string head = Console.ReadLine();
            Console.WriteLine("Choose a body: (GHOST/BUG/MONSTER) ");
            string body = Console.ReadLine();
            Console.WriteLine("Choose feet: (GHOST/BUG/MONSTER) ");
            string feet = Console.ReadLine();

            Console.WriteLine("\nCreating creature ... ");
            BuildACreature(head, body, feet);

        }


        static void BuildACreature(string head, string body, string feet)
        {
            Random randomNumber = new Random();

            int headNum;
            int bodyNum;
            int feetNum;

            if (head.ToUpper() != "ghost" || head.ToUpper() != "monster" || head.ToUpper() != "bug")
            {
                headNum = randomNumber.Next(1, 4);
            } else
            {
                headNum = TranslateToNumber(head.ToUpper());
            }

            if (body.ToUpper() != "ghost" || body.ToUpper() != "monster" || body.ToUpper() != "bug")
            {
                bodyNum = randomNumber.Next(1, 4);
            } else
            {
                bodyNum = TranslateToNumber(body.ToUpper());
            }

            if (feet.ToUpper() != "ghost" || feet.ToUpper() != "monster" || feet.ToUpper() != "bug")
            {
                feetNum = randomNumber.Next(1, 4);
            } else
            {
                feetNum = TranslateToNumber(feet.ToUpper());
            }

            SwitchCase(headNum, bodyNum, feetNum);

        }

        static void RandomMode()
        {
            Random randomNumber = new Random();

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            SwitchCase(head, body, feet);

        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;

                case 2:
                    BugHead();
                    break;

                case 3:
                    MonsterHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;

                case 2:
                    BugBody();
                    break;

                case 3:
                    MonsterBody();
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;

                case 2:
                    BugFeet();
                    break;

                case 3:
                    MonsterFeet();
                    break;
            }

        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;

                case "bug":
                    return 2;

                case "monster":
                    return 3;

                default:
                    return 0;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
