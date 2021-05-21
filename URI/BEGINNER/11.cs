using System; 

class URI {

    static void Main(string[] args) { 

   System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            double R;

           

            R = Convert.ToDouble(Console.ReadLine());
      

            double pi = 3.14159;

            double result = (4.0/3) * pi * Math.Pow(R, 3); 




            Console.WriteLine("VOLUME = " + (String.Format("{0:F3}", result)));
    }

}