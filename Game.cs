using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Game
    {
        DoublyLinkedStringList room1;
        DoublyLinkedStringList room2;
        DoublyLinkedStringList room3;
        string[] stats;
        public Game() 
        {
            
        }

        public void startGame()// Sets up variables
        {
            StreamReader reader = new StreamReader("Stats.txt");
            stats= reader.ReadLine().Split(',');
            string[] monster1 = reader.ReadLine().Split(' ');
            room1 = new DoublyLinkedStringList(true,false,null,null,monster1);
            string[] monster2 = reader.ReadLine().Split(' ');
            room2 = new DoublyLinkedStringList(false,false,null,room1,monster2);
            string[] monster3 = reader.ReadLine().Split(' ');
            room3 = new DoublyLinkedStringList(false,true,null,room2,monster3);
            room2.setNext(room3);
            room1.setNext(room2);
            reader.Close();
        }

        public void runGame()
        {
            Console.WriteLine("Enter a number 1-3 to enter that room and fight");
            string choice = Console.ReadLine();
            switch (choice)//Determines output
            {
                default:
                    {
                        Console.WriteLine("error in input");
                        break;
                    }
                case "1":
                    {
                        foreach(var stat in stats.Zip(room1.theList,Tuple.Create)) //Credit for iteratating through 2 lists simlutaneously https://stackoverflow.com/questions/1955766/iterate-two-lists-or-arrays-with-one-foreach-statement-in-c-sharp
                        {
                            Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            
                        }
                        Console.WriteLine("\nDo you defeat this monster?(y/n)");
                        if (Console.ReadLine() == "n")//If player decide they fail game is over
                        {
                            Console.WriteLine("You Die!");
                            Console.ReadLine();
                            return;
                        }
                        Console.WriteLine("Which room do you want to enter?(2 or 3)");
                        string choice2 = Console.ReadLine();
                        if(choice2 == "2")
                        {
                            foreach (var stat in stats.Zip(room1.next.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                            foreach (var stat in stats.Zip(room1.next.next.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                        }
                        else
                        {
                            foreach (var stat in stats.Zip(room1.next.next.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                            foreach (var stat in stats.Zip(room1.next.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                        }
                        break;
                    }
                case "2":
                    {
                        foreach (var stat in stats.Zip(room2.theList, Tuple.Create)) //Credit for iteratating through 2 lists simlutaneously https://stackoverflow.com/questions/1955766/iterate-two-lists-or-arrays-with-one-foreach-statement-in-c-sharp
                        {
                            Console.WriteLine($"{stat.Item1}: {stat.Item2}");

                        }
                        Console.WriteLine("\nDo you defeat this monster?(y/n)");
                        if (Console.ReadLine() == "n")
                        {
                            Console.WriteLine("You Die!");
                            Console.ReadLine();
                            return;
                        }
                        Console.WriteLine("Which room do you want to enter?(1 or 3)");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "3")
                        {
                            foreach (var stat in stats.Zip(room2.next.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                            foreach (var stat in stats.Zip(room2.previous.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                        }
                        else
                        {
                            foreach (var stat in stats.Zip(room2.previous.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                            foreach (var stat in stats.Zip(room2.next.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                        }
                        break;
                    }
                case "3":
                    {
                        foreach (var stat in stats.Zip(room2.theList, Tuple.Create)) //Credit for iteratating through 2 lists simlutaneously https://stackoverflow.com/questions/1955766/iterate-two-lists-or-arrays-with-one-foreach-statement-in-c-sharp
                        {
                            Console.WriteLine($"{stat.Item1}: {stat.Item2}");

                        }
                        Console.WriteLine("\nDo you defeat this monster?(y/n)");
                        if (Console.ReadLine() == "n")
                        {
                            Console.WriteLine("You Die!");
                            Console.ReadLine();
                            return;
                        }
                        Console.WriteLine("Which room do you want to enter?(1 or 2)");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "2")
                        {
                            foreach (var stat in stats.Zip(room3.previous.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                            foreach (var stat in stats.Zip(room3.previous.previous.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                        }
                        else
                        {
                            foreach (var stat in stats.Zip(room3.previous.previous.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                            foreach (var stat in stats.Zip(room3.previous.theList, Tuple.Create))
                            {
                                Console.WriteLine($"{stat.Item1}: {stat.Item2}");
                            }
                            Console.WriteLine("\nDo you defeat this monster?(y/n)");
                            if (Console.ReadLine() == "n")
                            {
                                Console.WriteLine("You Die!");
                                Console.ReadLine();
                                return;
                            }
                        }
                        break;
                    }
            }
            Console.WriteLine("You Win!");
            Console.ReadLine();
        }
    }
}
