using System; 

class URI {

    static void Main(string[] args) { 

                  var Dia1 = Console.ReadLine();
            var data = Dia1.Split(' ');
            string at = data[0];
            var a = int.Parse(data[1]);

            var line1 = Console.ReadLine();
            var data1 = line1.Split(' ');
            var b = int.Parse(data1[0]);
            string bt = data1[1];
            var b1 = int.Parse(data1[2]);
            string bt1 = data1[3];
            var b2 = int.Parse(data1[4]);


            var Dia2 = Console.ReadLine();
            var data2 = Dia2.Split(' ');
            string a1t = data2[0];
            var a1 = int.Parse(data2[1]);

            var line2 = Console.ReadLine();
            var data3 = line2.Split(' ');
            var c = int.Parse(data3[0]);
            string ct = data3[1];
            var c1 = int.Parse(data3[2]);
            string ct1 = data3[3];
            var c2 = int.Parse(data3[4]);

            int d = 0, h = 0, m = 0, s = 0;

            if (b > c || b == c & b1 > c1)
                d--;

            if (b2 > c2)
                m--;



            while (a != a1)
            {
                d++;
                a++;
            }

            Console.WriteLine(d + " dia(s)");


            if (c < b)
            {
                h = 24 + (c - b);
                if (b1 > c1 || b1 == c1 & b2 > c2)
                {
                    h--;
                    Console.WriteLine(h + " hora(s)");
                }
                else
                {
                    Console.WriteLine(h + " hora(s)");
                }

                
            }

            else if (b < c)
            {
                h = c - b;
                if (b1 > c1 || b1 == c1 & b2 > c2)
                {
                    h--;
                    Console.WriteLine(h + " hora(s)");
                }
                else
                {
                    Console.WriteLine(h + " hora(s)");
                }
               
            }

            else if (b == c)
            {
                

                if (b1 > c1 || b1 == c1 & b2 > c2)
                {
                    h = 24;
                    h--;
                    Console.WriteLine(h + " hora(s)");
                }
                else
                {
                    Console.WriteLine(h + " hora(s)");
                }
            }





            if (c1 < b1)
            {
                m = 60 + (c1 - b1);
                if (b2 > c2 || b1 == c1 & b2 > c2)
                {
                    m--;
                    Console.WriteLine(m + " minuto(s)");
                }
                else
                {
                    Console.WriteLine(m + " minuto(s)");
                }
            }
            else if (b1 < c1)
            {
                m = c1 - b1;
                if (b2 > c2 || b1 == c1 & b2 > c2)
                {
                    m--;
                    Console.WriteLine(m + " minuto(s)");

                }
                else
                {
                    Console.WriteLine(m + " minuto(s)");
                }
               
            }

            else if (b2 > c2 || b1 == c1 & b2 > c2)
            {
                m = 60;
                m--;
                Console.WriteLine(m + " minuto(s)");
            }
            else if (b1 == c1)
            {
                Console.WriteLine("0 minuto(s)");
            }



            if (c2 < b2)
            {
                s = 60 + (c2 - b2);
                Console.WriteLine(s + " segundo(s)");
            }
            else if (b2 < c2)
            {
                s = c2 - b2;
                Console.WriteLine(s + " segundo(s)");
            }
            else if (b2 == c2)
                Console.WriteLine("0 segundo(s)");


    }

}