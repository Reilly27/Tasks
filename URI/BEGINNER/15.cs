using System; 

class URI {

    static void Main(string[] args) { 

       string line = Console.ReadLine();
            var data = line.Split(' ');
            double b = double.Parse(data[0]);
            double c = double.Parse(data[1]);

            

            string line1 = Console.ReadLine();
            var data1 = line1.Split(' ');
            double b1 = double.Parse(data1[0]);
            double c1 = double.Parse(data1[1]);

            double rts = b1 - b;
            double rts2 = c1 - c;

            double otv = Math.Sqrt(Math.Pow(rts, 2) + Math.Pow(rts2, 2)); 



            Console.WriteLine( (String.Format("{0:F4}", otv)));



    }

}