using System; 

class URI {

    static void Main(string[] args) { 

       double a = double.Parse(Console.ReadLine());
          

            if (a <= 2000)
            {
                Console.WriteLine("Isento");
            }

            else if (a > 2000 && a<=3000)
            {
                double ot = a - 2000;
                double ot_o = (ot * 8)/100;
                double otv = ot_o;
                Console.WriteLine("R$ " + (String.Format("{0:F2}", otv)));
            }
            else if (a > 3000 && a <= 4500)
            {
                double ot = a - 2000;
                double ot1 = ot - 1000;
                ot -= ot1;
                double ot_o = (ot * 8) / 100;               
                double ot1_o = (ot1 * 18) /100;
                double otv = ot_o + ot1_o;

                Console.WriteLine("R$ " + (String.Format("{0:F2}", otv)));
            }

            else if (a > 4500)
            {
                double ot = a - 2000;
                double ot1 = ot - 1000;
                double ot2 = ot1 - 1500;
                ot -= ot1;
                ot1 -= ot2;
                double ot_o = (ot * 8) / 100;
                double ot1_o = (ot1 * 18) / 100;
                double ot2_o = (ot2 * 28) / 100;
                double otv = ot_o + ot1_o + ot2_o;

                Console.WriteLine("R$ " + (String.Format("{0:F2}", otv)));
            }

    }

}