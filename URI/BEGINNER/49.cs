using System; 

class URI {

    static void Main(string[] args) { 

        
            int A;
            A = int.Parse(Console.ReadLine());


            for (int i = 2; i <= A; i += 2)
            {
                Console.WriteLine(i + "^2 = " + (i * i));
            }


    }

}