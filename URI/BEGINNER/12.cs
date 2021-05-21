using System; 

class URI {

    static void Main(string[] args) { 

         string line = Console.ReadLine();
            var data = line.Split(' ');
            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            double c = double.Parse(data[2]);

            double ot = (a * c) / 2;

            double ot2 = c * c * 3.14159;

            double ot3 = ((a + b) / 2) * c;

            double ot4 = b * b;

            double ot5 = a * b;






  Console.WriteLine("TRIANGULO: " + (String.Format("{0:F3}", ot)));
            Console.WriteLine("CIRCULO: " + (String.Format("{0:F3}", ot2)));
            Console.WriteLine("TRAPEZIO: " + (String.Format("{0:F3}", ot3)));
            Console.WriteLine("QUADRADO: " + (String.Format("{0:F3}", ot4)));
            Console.WriteLine("RETANGULO: " + (String.Format("{0:F3}", ot5)));


    }

}