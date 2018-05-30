using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Technical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            SAM sam = new SAM(20);

            Console.WriteLine(sam.ToString());
            Console.ReadKey();
            


        }

        public class SAM{

            private double calories, min = 0;
            private int resultsTime = 0;


            public SAM(int min){

                //Constructor class
                this.calories = 0;
                this.min = min;
                this.resultsTime = 0;
            }

            public SAM(int calories, int min, int resultsTime)
            {
                this.calories = calories;
                this.min = min;
                this.resultsTime = resultsTime;
            }



            //setters and getter
            public double Calories { get => calories; set => calories = value; }
            public double Min { get => min; set => min = value; }
            public int ResultsTime { get => resultsTime; set => resultsTime = value; }


            //calculate calories method
            private void calculateCals() {

                DateTime start = DateTime.Now;
           
                
                calories = Math.Ceiling(
                             Convert.ToDouble(
                                 Decimal.Divide(200,15)) * min);

                DateTime end = DateTime.Now;

                TimeSpan span = end - start;

                resultsTime = (int)span.TotalSeconds;
            }

           
                    

            public override string ToString()
            {
                calculateCals();
                return  "You ran for " + min + " minutes.  You have burned " + calories + " calories \n The result returned " + resultsTime + " in seconds";
            }



        }

    }
}
