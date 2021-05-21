using System; 

class URI {

    static void Main(string[] args) { 

          int inputnamb = Convert.ToInt32(Console.ReadLine());

            ae(inputnamb);

        }

        public static void ae (int inputnamb)
        {

            for(int i = 1; i <= inputnamb; i++)
            {
                var Dia1 = Console.ReadLine();
                var data = Dia1.Split(' ');
                var a = double.Parse(data[0]);
                var b = double.Parse(data[1]);
                var c = double.Parse(data[2]);


                double output = ((a / 10) * 2) + ((b / 10) * 3) + ((c / 10) * 5);

                Console.WriteLine((String.Format("{0:F1}", output)));
            }
        }



}