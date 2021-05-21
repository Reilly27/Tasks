using System; 

class URI {

    static void Main(string[] args) { 

     double a, b;

            Console.ReadLine();

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
           

            double result = a + b * 0.15; 
    


            
            Console.WriteLine("TOTAL = R$ " + (String.Format("{0:F2}",result)));
    }

}