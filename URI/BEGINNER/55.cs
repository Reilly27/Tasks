using System; 

class URI {

    static void Main(string[] args) { 
   int a = 1;
            int b = 1;
            int c = 60;

            Console.WriteLine("I=" + b + " J=" + c);
            while (a <= 12)
            {
                a++;
                b += 3;
                c -= 5;

                Console.WriteLine("I="+b+ " J="+ c);
            }

    }

}