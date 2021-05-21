using System; 

class URI {

    static void Main(string[] args) { 

        int x = 0;
            int a = int.Parse(Console.ReadLine());
            while (x <= 1000)
            {
                if(x == a)
                {
                    break;
                }
                x++;

                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }

            }

    }

}