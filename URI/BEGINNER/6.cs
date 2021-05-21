using System; 

class URI {

    static void Main(string[] args) { 


            double a, b, с;

            

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            с = Convert.ToDouble(Console.ReadLine());


            double result = ((a * 2) + (b * 3) + (с * 5)) / (3 + 2 + 5);




            Console.WriteLine("MEDIA = " + (String.Format("{0:F1}",result)));
    }

}