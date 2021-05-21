using System; 

class URI {

    static void Main(string[] args) { 

      int A = int.Parse(Console.ReadLine());

            
            int g = A / 365;
            int m = A % 365 / 30;
            int d = A % 365 % 30; 



            Console.WriteLine(g + " ano(s)");
            Console.WriteLine(m + " mes(es)");
            Console.WriteLine(d+ " dia(s)");
    }

}