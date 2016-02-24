using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen_4_2
{
    class Program
    {
        //public instance variables
        public static bool[] seat;
        public static int totalRemainedFirstClass;
        public static int totalRemainedEconomyClass;
        public static int indexFirstClass = 1;
        public static int indexEconomyClass = 6;
        static void Main(string[] args)
        {

            seat = new bool[11];
            totalRemainedFirstClass = 5;
            totalRemainedEconomyClass = 5;
            int selection = 0;

            //Assign false value to all seat array element
            for (int i = 0; i < 11; i++)
            {
                seat[i] = false;
            }


            //excute a loop when selection is not '3'
            while (selection != 3)
            {
                selection = reservationMenu(selection);

                switch (selection)
                {
                    case 1:

                        //user cannot reserve seats when all remained seats are not availalbe
                        if (totalRemainedFirstClass == 0 && totalRemainedEconomyClass == 0)
                        {
                            Console.WriteLine("All seats are reserved. You cannot reserve.");
                        }
                        //user can reserve a seat when First Class seat is available
                        else if (totalRemainedFirstClass > 0)
                        {
                            AssignFirstClass();
                        }
                        //ask wether the user reserve Economy class seat when FirstClass seat is not available
                        else if (totalRemainedFirstClass == 0 && totalRemainedEconomyClass > 0)
                        {
                            Console.WriteLine("No seats are available in First class.");
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("+++     1. Reserve Economy Class    +++");
                            Console.WriteLine("+++     2. No, I do not want it     +++");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine();
                            Console.Write("Type the number you want: ");

                            int secondSelection = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (secondSelection)
                            {
                                case 1:
                                    AssignEconomyClass();
                                    break;

                                case 2:
                                    Console.WriteLine("Next flight leaves in 3 hours.");
                                    break;

                                default:
                                    break;
                            }
                        }
                        break;


                    case 2:
                        //user cannot reserve seats when all remained seats are not availalbe
                        if (totalRemainedFirstClass == 0 && totalRemainedEconomyClass == 0)
                        {
                            Console.WriteLine("All seats are reserved. You cannot reserve.");
                        }
                        //user can reserve a seat when Economy Class seat is available
                        else if (totalRemainedEconomyClass > 0)
                        {
                            AssignEconomyClass();
                        }
                        //ask wether the user reserve First class seat when Economy Class seat is not available
                        else if (totalRemainedFirstClass > 0 && totalRemainedEconomyClass == 0)
                        {
                            Console.WriteLine("No seats are available in Economy class.");
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("+++     1. Reserve First Class      +++");
                            Console.WriteLine("+++     2. No, I do not want it     +++");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine();
                            Console.Write("Type the number you want: ");

                            int secondSelection = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (secondSelection)
                            {
                                case 1:
                                    AssignFirstClass();
                                    break;
                                case 2:
                                    Console.WriteLine("Next flight leaves in 3 hours.");
                                    break;
                                default:
                                    break;
                            }
                        }

                        break;

                    case 3:
                        break;
                    default:
                        Console.WriteLine("invalid selection. Please, Select again...");
                        break;
                }
            }

        }
        //Method which assign user to First Class seat
        public static void AssignFirstClass()
        {

            bool occupiedFlag = false;
            //excute loop until Find vacant First Class seat 
            while (occupiedFlag != true)
            {
                //if selected seat is vacant, assign a seat and change occupiedFlag to 'true'
                if (seat[indexFirstClass] == false)
                {
                    seat[indexFirstClass] = true;
                    Console.WriteLine("You reserved First Class seat!");
                    totalRemainedFirstClass--;
                    occupiedFlag = true;
                }
                //else display the message and maintain occupiedFlag as 'false'
                else
                {
                    Console.WriteLine("Sorry, It is not avaliable");
                    occupiedFlag = false;
                }

            }

            Console.WriteLine();

            Console.WriteLine("Your seat is {0}", indexFirstClass);
            indexFirstClass++;
        }

        //Method which assign user to Economy Class seat
        public static void AssignEconomyClass()
        {

            bool occupiedFlag = false;
            //excute loop until Find vacant Economy Class seat 
            while (occupiedFlag != true)
            {
                //if selected seat is vacant, assign a seat and change occupiedFlag to 'true'
                if (seat[indexEconomyClass] == false)
                {
                    seat[indexEconomyClass] = true;
                    Console.WriteLine("You reserved First Class seat!");
                    totalRemainedEconomyClass--;
                    occupiedFlag = true;
                }
                //else display the message and maintain occupiedFlag as 'false'
                else
                {
                    Console.WriteLine("Sorry, It is not avaliable");
                    occupiedFlag = false;
                }

            }

            Console.WriteLine();

            Console.WriteLine("Your seat is {0}", indexEconomyClass);
            indexEconomyClass++;
        }



        //Method which display reservation menu
        public static int reservationMenu(int choice)
        {

            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("+++     1. First Class    +++");
            Console.WriteLine("+++     2. Economy        +++");
            Console.WriteLine("+++     3. Exit           +++");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.Write("Type your seletion: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }




}


