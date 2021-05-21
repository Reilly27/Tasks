using System; 

class URI {

    static void Main(string[] args) { 

       int C = 0, R = 0, S = 0, t = 0;

            double pcC = 0, pcR = 0, pcS = 0;


            int imput = int.Parse(Console.ReadLine());
            for(int i =0; i <imput; i++) 
                {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                var A = int.Parse(data[0]);
                string A1 = (data[1]);

                t += A;
                if(A1 == "C")
                {
                    C += A;
                }
                else if(A1 == "R")
                {
                    R += A;
                }
                else if (A1 == "S")
                {
                    S += A;
                }

                pcC = (C * 100.00) / t;
                pcR = (R * 100.00) / t;
                pcS = (S * 100.00) / t;
            }

            Console.WriteLine("Total: " + t + " cobaias");
            Console.WriteLine("Total de coelhos: " + C);
            Console.WriteLine("Total de ratos: " + R);
            Console.WriteLine("Total de sapos: " + S);

            Console.WriteLine("Percentual de coelhos: " + (String.Format("{0:F2}", pcC)) + " %");
            Console.WriteLine("Percentual de ratos: " + (String.Format("{0:F2}", pcR)) + " %");
            Console.WriteLine("Percentual de sapos: " + (String.Format("{0:F2}", pcS)) + " %");

    }

}