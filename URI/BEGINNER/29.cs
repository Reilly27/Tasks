using System; 

class URI {

    static void Main(string[] args) { 

      var line = Console.ReadLine();
            var data = line.Split(' ');
            var A = int.Parse(data[0]);
            var B = int.Parse(data[1]);

            if (B % A == 0 || A % B == 0)

            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

    }

}