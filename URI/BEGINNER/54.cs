using System; 

class URI {

    static void Main(string[] args) { 
  int no = 0;
            int b = 0;
            int c = 0;
            while(no < 100)
                {
                no++;

                int a = Convert.ToInt32(Console.ReadLine());

                if(a > b)
                {
                    b = a;
                     c = no;
                    
                }

            }
            Console.WriteLine(b);
            Console.WriteLine(c);

    }

}