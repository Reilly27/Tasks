using System; 

class URI {

    static void Main(string[] args) { 

         double a, b, c, d;

            

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());

            double result = a * b - c * d;




            Console.WriteLine("DIFERENCA = " + (String.Format("{0:F0}",result)));
        
    }

}