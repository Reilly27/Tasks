using System; 

class URI {

    static void Main(string[] args) { 

       int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10000; i++)
            {
                if (i % a == 2)
                    Console.WriteLine(i);


            }


    }

}