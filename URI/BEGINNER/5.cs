using System; 

class URI {

    static void Main(string[] args) { 

   double a, b;

            a= 3.5;
            b= 7.5;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());



            double result = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);




            Console.WriteLine("MEDIA = " + (String.Format("{0:F5}",result)));
    }

}