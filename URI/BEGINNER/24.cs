using System; 

class URI {

    static void Main(string[] args) { 

      var line = Console.ReadLine();
            var data = line.Split(' ');
            var X = double.Parse(data[0]);
            var Y = double.Parse(data[1]);
            if (X == 1)
            {
                X = 4.00;
            }
            else if (X == 2)
            {
                X = 4.50;
            }
            else if (X == 3)
            {
                X = 5.00;
            }
            else if (X == 4)
            {
                X = 2.00;
            }

            else if (X == 5)
            {
                X = 1.50;
            }

            double ot = X * Y;


            Console.WriteLine("Total: R$ " + (String.Format("{0:F2}", ot)));

    }

}