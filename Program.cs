using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorrian_Horsey_Fortune_Teller_Project
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! I'm going to tell you your fortune. Let's get started!");

            Console.WriteLine("Please type your first name.");
            string firstName = (Console.ReadLine().ToLower());

            Console.WriteLine("Please type your last name.");
            string lastName = (Console.ReadLine().ToLower());

            Console.WriteLine("Cool. How old are you?"); //this question allows user to input information that can be used to predict their retirement age 
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a great age. Now please type the number of your birth month. E.g. Jan=1 and Dec=12 "); //This question allows the user input information that can be used to predict how much money they have in the bank.
            int userBirthMonth = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Think about the rainbow and type your favorite ROYGBIV color.");//This question allows the user to input information that can be used to predict their mode of transportation.
            Console.WriteLine("If you don't know what ROYGBIV is, please type the word \"Help.\"");

            string userFavoriteColor = (Console.ReadLine().ToLower());

            string[] roygbiv = { "R=Red", "O=Orange", "Y=Yellow", "G=Green", "B=Blue", "I=Indigo", "V=Violet" };


            if (userFavoriteColor == "help")
            {
                foreach (string color in roygbiv)  //allows computer to loop through different colors in array
                    Console.WriteLine(color);

                Console.WriteLine("Ok. Now that you've seen the options, what is your favorite color?");
                userFavoriteColor = (Console.ReadLine().ToLower());
            }


            Console.WriteLine("Ok. One more question...How many siblings do you have?"); //this question allows user to input information that can be used to predict location of their vacation home.
            int numberOfSiblings = int.Parse(Console.ReadLine());


            //PART 2//


            int userRetirementAge; //declare variable to store retirement age for user based on whether their age is even or odd number

            if (userAge % 2 == 0)  // evaluate expression to determine whether user will retire in 15 years if their current age is an even number
                                   // or whether user will retire in 20 years if their current age is an odd number.
            {
                userRetirementAge = 15;
            }

            else
            {

                userRetirementAge = 20;
            }


            string vacationHomeLocation; //declare variable to store location of vacation home based on number of siblings user typed

            if (numberOfSiblings == 0)
            {
                vacationHomeLocation = "gorgeous Aspen";
            }
            else if (numberOfSiblings == 1)
            {
                vacationHomeLocation = "lovely Hawaii";
            }
            else if (numberOfSiblings == 2)
            {
                vacationHomeLocation = "sunny Miami";
            }
            else if (numberOfSiblings == 3)
            {
                vacationHomeLocation = "beautiful Rio de Janeiro";
            }
            else if (numberOfSiblings >= 4)
            {
                vacationHomeLocation = "amazing Switzerland";
            }
            else
            {
                vacationHomeLocation = "a warzone!!";
            }



            //switch (numberOfSiblings) // code below allows code to substitute different locations based on the number of siblings user inputs in line 50.
            //{
            //    case 0:

            //        vacationHomeLocation = "gorgeous Aspen";
            //        break;

            //    case 1:

            //        vacationHomeLocation = "lovely Hawaii";
            //        break;

            //    case 2:

            //        vacationHomeLocation = "sunny Miami";
            //        break;

            //    case 3:

            //        vacationHomeLocation = "beautiful Rio De Janeiro";
            //        break;

            //    case 4:

            //        vacationHomeLocation = "amazing Switzerland";
            //        break;

            //    default:
            //        vacationHomeLocation = "A dangerous warzone";
            //        break;

            //}


            string transportationMethod;

            switch (userFavoriteColor)  // code below allows code to substitute different transportation methods based on color user entered in line 34 or 45


            {
                case "red":

                    transportationMethod = "a bicycle";
                    break;

                case "orange":

                    transportationMethod = "a roller skates";
                    break;

                case "yellow":

                    transportationMethod = "a mini van";
                    break;

                case "green":

                    transportationMethod = "a private jet";
                    break;

                case "blue":

                    transportationMethod = "a helicopter";
                    break;

                case "indigo":

                    transportationMethod = " roller skates";
                    break;

                case "violet":

                    transportationMethod = "a yacht";
                    break;

                default:

                    transportationMethod = "your own feet!";
                    break;

            }

            decimal moneyInBank;

            switch (userBirthMonth)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    moneyInBank = 227.05m;
                    break;

                case 5:
                case 6:
                case 7:
                case 8:

                    moneyInBank = 925.07m;
                    break;

                case 9:
                case 10:
                case 11:
                case 12:

                    moneyInBank = 904.13m;
                    break;


                default:
                    moneyInBank = 0.00m;
                    break;

            }


            //PART 3

            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine(fullName + " will retire in " + userRetirementAge + " years with  $" + moneyInBank + " dollars in the bank, a vacation home in " + vacationHomeLocation + " and get around on " + transportationMethod);
        }
    }
}

