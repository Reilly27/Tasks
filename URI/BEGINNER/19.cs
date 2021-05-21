using System; 

class URI {

    static void Main(string[] args) { 

      int A = int.Parse(Console.ReadLine());

            int m = (A / 60) % 60;           
            int s = A % 60;
            int m1 = A / 60;
            int h = m1 / 60;



            Console.WriteLine(h+":"+m+":"+s);
          
    }

}