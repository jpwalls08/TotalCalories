using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace TotalCalories
{
    public class Calories
    {
        static void Main(string[] args)
        {

            #region Attempt_1

            //string[] elfCalories = new string[10];
            //Console.WriteLine("Below is a list of elves' and their total calories from greatest to least greatest.\n" +
            //    "Just enter in your Calories for a single elf and we'll handle the rest!\n");

            //{
            //    for (int i = 0; i < elfCalories.Length; i++)
            //    {
            //        elfCalories[i] = Console.ReadLine();
            //    }
            //    int isElf = i + 1;
            //    Console.WriteLine(isElf + " Elf: " + elfCalories[i]);

            //    for (int i = 0; i < elfCalories.Length; i++)
            //    {
            //        int isElf = i + 1;
            //        Console.WriteLine(isElf + " Elf: " + elfCalories[i]);
            //    }

            //    //int sum = arr.Sum();
            //    //Console.WriteLine("Total Calories" + sum);
            //    Array.Sort(elfCalories);
            //    for (int i = 0; i < elfCalories.Length; i++)
            //    {
            //        Console.WriteLine(elfCalories[i]);
            //    }

            #endregion


            #region Attempt_2
            //List<string> elfCalList = new List<string>();

            ////elfCalList.Add("Calories");

            //int length = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int input = 0;
            //for (int i = 0; i < elfCalList.Count; i++)
            //{
            //    Console.Write(elfCalList[i] + "Elf:");
            //    sum += input;
            //}

            //int total = elfCalList.Sum();
            //elfCalList.Sort();
            #endregion

            #region Attempt_3
            //List<string> calInput = new List<string>();

            //Console.WriteLine("Below is a list of elves' and their total calories from greatest to least greatest.\n" +
            //    "Just enter in your Calories for a single elf and we'll handle the rest!\n");
            //string input = Console.ReadLine();
            //calInput.Add(input);

            //bool exit = true;
            //do
            //{
            //    Console.WriteLine(
            //        "A) Enter Calories\n" +
            //        "E) Enter new Elf Calories\n" +
            //        "C) Calculate Total Calories\n" +
            //        "D) List of Elves\n" +
            //        "X) EXIT\n");

            //    string userInput = Console.ReadKey(true).Key.ToString().ToUpper();
            //    Console.Clear();

            //    switch (userInput)
            //    {
            //        case "A":
            //            while (!string.IsNullOrEmpty(input))
            //            {
            //                calInput.Add(input);
            //                Console.WriteLine("Please enter Calories per Elf.");
            //                input = Console.ReadLine();
            //            }
            //            break;

            //        case "B":
            //            Console.WriteLine("Please enter Calories.");
            //            break;

            //        case "C":
            //            while (!string.IsNullOrEmpty(input))
            //            {
            //                calInput.Add(input);
            //                input = Console.ReadLine();
            //            }
            //            if (calInput.Count > 0)
            //            {
            //                Console.WriteLine("Total Calories = " + calInput.Count);
            //            }

            //            else
            //            {
            //                Console.WriteLine("You have entered 0 Calories.");
            //            }
            //            break;

            //        case "D":
            //            Console.WriteLine("Calories listed per Elf from Greatest to Least Greatest");
            //            Console.WriteLine(calInput);
            //            break;

            //        case "X":
            //        case "Esc":
            //        case "End":
            //            Console.WriteLine("Thank you for participating! Comeback if you need to add anymore!");
            //            //if (userInput.Length("X", "Esc", "End"))
            //            //{
            //            //    exit = true;
            //            //    break;
            //            //}
            //            exit = true;
            //            break;
            //    }



            //} while (!exit);

            //while (!string.IsNullOrEmpty(input))
            //{
            //    calInput.Add(input);
            //    Console.WriteLine("Please enter Calories per Elf.");
            //    input = Console.ReadLine();
            //}

            //if (calInput.Count > 0)
            //{
            //    Console.WriteLine("Total Calories = " + calInput.Count);
            //}

            //else
            //{
            //    Console.WriteLine("You have entered 0 Calories.");
            //}

            #endregion


            #region Attempt_4

            string[] lines = File.ReadLines("C:/Advent/Challenges/Challenge012022");

            List<Elf> elves = new List<Elf>();
            string name = "First";
            int total = 0;
            Elf e = new Elf();
            e.Name = name;
            int elfcount = 0;

            foreach (string r in lines)
            {
                r.Split(',')
                    if (r = "")
                {
                    ++icount;
                    e.totalCal = total;
                    elves.Add(e);

                    e = new Elf();
                    e.Name = "Elf" + icount.ToString();
                }
                total += int.TryParse(r);

                Console.WriteLine("--{0}", r);
            }

            elves.Sort(type)

                Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        };

        private class Elf
        {
            public string name;
            public int totalCal;
        };


        #endregion

        //Console.ReadKey();               

        //}


    }

}

};


