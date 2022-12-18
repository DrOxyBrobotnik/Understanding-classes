namespace Understanding_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Katzenwagen";
            myCar.Model = "Purrmachine";
            myCar.Year = 2022;
            myCar.Color = "White";
            myCar.Speed = "Fast af";

            Console.WriteLine("{0} {1} {2} {3} {4}" + ", this information",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color,
                myCar.Speed);

            double value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());


            Console.ReadLine();
        }

        private static double DetermineMarketValue(Car car)
        {
            double carValue = 100.0;
            return carValue;
            //someday I might look up the car
            //in an online web service
            //to get the accurate value
            
            
        }




    }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public string Speed { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 500 * 2;
            else
                carValue = 300;

            return carValue;
        }


        }

    }
