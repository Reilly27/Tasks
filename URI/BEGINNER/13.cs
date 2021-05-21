using System; 

class URI {

    static void Main(string[] args) { 

        string line = Console.ReadLine();
            var data = line.Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);


            if (a > b && a > c)
            {
                Console.WriteLine(a + " eh o maior");
            }


                if (b > c && b > a)
                {

                    Console.WriteLine(b + " eh o maior");

                }

                if (c > b && c > a)
                {
                    Console.WriteLine(c + " eh o maior");
                }


    }

}