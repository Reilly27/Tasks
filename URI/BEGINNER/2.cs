using System; 

class URI {

    static void Main(string[] args) { 

       System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
          
          

            double R;

            

            R = Convert.ToDouble(Console.ReadLine());

            double p = 3.14159;

            double result = p * Math.Pow(R,2);

          


            Console.WriteLine("A=" + (String.Format("{0:F4}",result)));

    }

}