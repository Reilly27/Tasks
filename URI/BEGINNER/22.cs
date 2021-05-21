using System; 

class URI {

    static void Main(string[] args) { 

      string line = Console.ReadLine();
            var data = line.Split(' ');
            var a = double.Parse(data[0]);
            var b = double.Parse(data[1]);
            var c = double.Parse(data[2]);





            if (((b * b) - 4 * a * c) < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }


            else
            {
                var t = ((-b + Math.Sqrt(((b * b) - (4 * a * c)))) / (2 * a));
                var t2 =((-b - Math.Sqrt(((b * b) - (4 * a * c)))) / (2 * a));
                Console.WriteLine("R1 = " + (String.Format("{0:F5}", t)));
                Console.WriteLine("R2 = " + (String.Format("{0:F5}", t2)));
            }


    }

}