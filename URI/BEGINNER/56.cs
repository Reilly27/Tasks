using System; 

class URI {

    static void Main(string[] args) { 

        int[] a = new int[3];
            a[0] = 1;
            a[1] = 1;
            a[2] = 1;

            int[] b = new int[3];

            b[0] = 7;
            b[1] = 6;
            b[2] = 5;

            Console.WriteLine("I=" + a[0] + " J=" + b[0] + "\n" + "I=" + a[1] + " J=" + b[1] + "\n" + "I=" + a[2] + " J=" + b[2]);

            for (int i = 1; i < 5; i++)
            {
                a[0] +=2;
                a[1] += 2;
                a[2] += 2;

                Console.WriteLine("I=" + a[0] + " J=" + b[0]+"\n" + "I=" + a[1] + " J=" + b[1] + "\n" + "I=" + a[2] + " J=" + b[2]);
            }

    }