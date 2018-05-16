using System;

namespace Lab11ZackRaycraft
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(names[1]);
            Console.WriteLine(names[4]);

            string[] months;
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            int i = 0;
            foreach (string element in months)
            {
                System.Console.WriteLine(element);
            }

            string[] seasons = {"Spring", "Summer", "Fall", "Winter"};

            foreach (string element in seasons)
            {
                System.Console.WriteLine(element);
            }

            int[] intArray = new int[999];

            while (intArray != null)
            {
                Random random = new Random();
                int randomNumber
            // Call this each time through the loop to get a new random number.
            randomNumber = random.Next(0, 100);  // place this line in the loop
                intArray = intArray[randomNumber];
            }

            foreach (int element in intArray)
            {
                System.Console.WriteLine(element);
            }


        }
    }
}
