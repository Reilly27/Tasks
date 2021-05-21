using System; 

class URI {

    static void Main(string[] args) { 

       string line = Console.ReadLine();
            var data = line.Split(' ');      
            double b = int.Parse(data[1]);
            double c = double.Parse(data[2]);

            double rts = b * c;


            string line1 = Console.ReadLine();
            var data1 = line1.Split(' ');            
            double b1 = int.Parse(data1[1]);
            double c1 = double.Parse(data1[2]);

            double rts2 = b1 * c1;

            double otvet = rts + rts2;
         
  Console.WriteLine("VALOR A PAGAR: R$ " + (String.Format("{0:F2}", otvet)));
    }

}