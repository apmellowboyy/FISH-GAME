using System;
namespace greatAdventure
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int patience = 0, confidence = 0, direction = 0, round = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What's good champ, you ready to fish?");
            string name = Console.ReadLine();
            initValues(ref patience, ref confidence, r);
            while (patience  > 0 && win==false)
            {
                direction = chooseDirection();
                /* the direction impacts the number passed to the actions method
                 * if they choose left, they will only receive bad outcomes
                 * if they choose right, they have a better chance of receiving 
                 * good outcomes along with the bad outcomes */
                if (direction == 1)
                    actions(r.Next(4), ref confidence, ref patience);
                else
                    actions(r.Next(10), ref confidence, ref patience);
                checkResults(ref round, ref patience, ref confidence, ref win);
            }
            if (win)
                Console.WriteLine("AYEEE good job on the haul!");
            else if (patience <= 0 && confidence<=0)
                Console.WriteLine("Your patience has worn and you left, maybe next time friend.");




            static void checkResults(ref int round, ref int patience, ref int confidence, ref bool win)
            {
                Console.WriteLine($"~~~~~~~~~Cast {round}~~~~~~~~~");
                Console.WriteLine("");
                Console.WriteLine($"Patience ={patience}");
                Console.WriteLine($"Confidence ={confidence}");
                round++;
                if (round >= 25)
                    win = true;
                return;

            }
        }

        private static int chooseDirection()
        {

            Console.WriteLine("You have come across 3 fishing holes, enter 1 for the small, 2 for the medium, or 3 for the large hole.");
            int direction = int.Parse(Console.ReadLine());
            while (direction != 1 && direction != 2 && direction !=3)
            {
                Console.WriteLine("Woah where are you going? Please choose a 1 of the 3 holes!");
                direction = int.Parse(Console.ReadLine());
            }
            return direction;
        }

        private static void initValues(ref int patience, ref int confidence, Random r)
        {
            
            patience = r.Next(10) + 1;
            confidence=r.Next(10) + 1;

            return;
        }

        private static void actions(int num, ref int patience, ref int confidence)
        {


            switch (num)
            {
                case 0:
                    Console.WriteLine("You casted your line, and pulled a BOOT.");

                    Console.WriteLine("You tried the BOOT on, just a tad to small. You lost 1 unit of confidence.");

                    confidence -=1;
                    break;
                case 1:
                    Console.WriteLine("You casted your line, and pulled a MEGA BASS.");
                    Console.WriteLine("You held the MEGA BASS to the sky, gaining 1 unit of Patience and Confidence.");
                    patience +=1;
                    confidence +=1;
                    break;

                case 2:
                    Console.WriteLine("You casted your line, and pulled a HEAVY WHEEL.");
                    Console.WriteLine("Fooled by the HEAVY WHEEL's weight, you lose 2 unit of patience.");


                    patience -= 2;
                    break;
                case 3:
                    Console.WriteLine("You casted your line, and pulled a SIX-PACK RING.");
                    Console.WriteLine("You contributed to saving turtles, gaining 2 confidence.");

                    confidence += 2;
                    break;

                case 4:
                    Console.WriteLine("You casted your line, and pulled THICK ALGAE.");
                    Console.WriteLine("It somehow got in your hair, dropping 2 confidence.");
                    confidence -= 2;

                    

                    break;
                case 5:
                    Console.WriteLine("You casted your line, and pulled a CRAPPIE.");
                    Console.WriteLine("Catching it you felt not so crappy, gaining 2 confidence.");
                    confidence += 2;

                    Console.WriteLine("You casted your line, and pulled A PAIR OF JORDANS.");
                    Console.WriteLine("You realize the value is diminished due to water damage, losing 2 patience.");
                    patience -= 2;

                    break;
                case 6:
                    Console.WriteLine("You casted your line, PULLING NOTHING.");
                    Console.WriteLine("Pulling nothing is embarrassing, losing 2 patience and confidence.");
                    patience -=2;
                    confidence -= 2;

                    

                    break;
                case 7:
                    Console.WriteLine("Instead of casting your line, you took a break and got TACO BELL.");
                    Console.WriteLine("Fulfilling your hunger, you gained 5 patience.");
                    patience+=5;

                    break;

                case 8:
                    Console.WriteLine("You casted your line, and pulled a SEA LAMPREY.");
                    Console.WriteLine("You felt good ridding the hole of such scum, gaining 4 patience.");

                    patience += 4;
                    break;

                case 9:
                    Console.WriteLine("You casted your line, and pulled a CATALYTIC CONVERTER.");
                    Console.WriteLine("You bubble at the mouth thinking of the free money! Gaining 2 confidence.");
                    confidence +=2;
                    break;
                default:
                    Console.WriteLine("You casted your line, and pulled a PIKE.");

                    Console.WriteLine("Nothing more standard than a PIKE, Gaining 2 patience.");

                    patience += 2;
                    break;
            }
        }
    }
}


