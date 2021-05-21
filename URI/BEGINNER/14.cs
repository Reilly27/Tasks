using System; 

class URI {

    static void Main(string[] args) { 

      double X,Y;



            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());



            double result = X / Y;




            Console.WriteLine((String.Format("{0:F3}", result) + " km/l"));

    }

}