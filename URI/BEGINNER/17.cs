using System; 

class URI {

    static void Main(string[] args) { 

   double A, B, C;



            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = 12;

            double result = (B / C) * A;



            Console.WriteLine((String.Format("{0:F3}", result)));

    }

}