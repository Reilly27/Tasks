using System; 

class URI {

    static void Main(string[] args) { 

       double a = 0, b = 0;


            for (int i = 1; i <= 6; i++)
            {
                double v = double.Parse(Console.ReadLine());

                if (v > 0)
                {
                    a+=1;
                    b += v;

                }
            }
            double c = b / a;
            Console.WriteLine(a + " valores positivos");
            Console.WriteLine(Math.Round(c, 1, MidpointRounding.ToEven));

    }

}