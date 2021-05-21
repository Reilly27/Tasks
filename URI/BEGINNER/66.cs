using System; 

class URI {

    static void Main(string[] args) { 

        double media = 0, total = 0, total2 = 0;
            while (total2 != 2) {
                double firstScore = double.Parse(Console.ReadLine());
                if (firstScore >= 0.0 && firstScore <= 10.0) {
                    total += firstScore;
                    total2 += 1;
                }
                else{
                    Console.WriteLine("nota invalida");
                }
            }
            media = (float)total / 2;
            Console.WriteLine("media = " + media);


    }

}