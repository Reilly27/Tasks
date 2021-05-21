using System; 

class URI {

    static void Main(string[] args) { 

   int a;
            double b, c;

            

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            double result = b * c;
            int result2 = a;


            Console.WriteLine("NUMBER = " + result2);
            Console.WriteLine("SALARY = U$ " + (String.Format("{0:F2}",result)));
    }

}