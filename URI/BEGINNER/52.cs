using System; 

class URI {

    static void Main(string[] args) { 

      
            int a = Convert.ToInt32(Console.ReadLine());           
            um(a);

    }
    
     public static void um(int a)
        {
            int i = 0;
            while (i < 10)
            {
                i++;

                int c = i * a;
                Console.WriteLine(i + " x " + a + " = " +  c);


            }


        }
    

}