using System; 

class URI {

    static void Main(string[] args) { 

      var line = Console.ReadLine();
            var data = line.Split(' ');
            var A = double.Parse(data[0]);
            var B = double.Parse(data[1]);
            var C = double.Parse(data[2]);


            if ((A < (B + C)) & (B < (A + C)) & (C < (B + A)))
            {

                double pr = A + B + C; 

                Console.WriteLine("Perimetro = " + (String.Format("{0:F1}", pr)));

            }




             else
                    {
                double pl = ((A + B) * C) / 2;


                        Console.WriteLine("Area = " + (String.Format("{0:F1}", pl)));
                    }
            

    }

}