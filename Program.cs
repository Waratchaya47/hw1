using System;
namespace hw {
    class program {
        static void Main(string[] args) {
            Console.Write("Input Password (6 number): ");
            int p = int.Parse(Console.ReadLine());

            int money = 0;
            
            if (p > 100000 && p < 1000000) {
                Console.Write("Input your affiliation: ");
                  string a = Console.ReadLine();
                  int p6 = 0;
                  int p5 = 0;
                  int p4 = 0;
                  int p3 = 0;
                  int p2 = 0;
                  int p1 = 0;
                  
                     switch(a) {
                        case "CIA": 
                          int x6c = (int)p / 100000;
                          p6 = p - (x6c * 100000);
                          Console.WriteLine(p6);
                          int x5 = (int)p6 / 10000;
                          p5 = p6 - (x5 * 10000);
                          int x4 = (int)p5 / 10000;
                          p5 = p5 - (x4 * 10000);
                          int x3 = (int)p4 / 10000;
                          p5 = p4 - (x3 * 10000);
                          break;
                        case "FBI":
                          int x6f = (int)p / 100000;
                          p6 = (int)x6f;
                          Console.WriteLine(p6);
                          break;
                        case "NSA":
                          money = 30;
                          break;
                        default :
                          Console.WriteLine("False");
                          break;
                     }

            } else {
                Console.WriteLine("False");
            }

        }
    }
}
