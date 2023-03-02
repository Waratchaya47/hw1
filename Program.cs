using System;
namespace hw {
    class program {
        static void Main(string[] args) {
            Console.Write("Input Password (6 number): ");
            int p = int.Parse(Console.ReadLine());

            
            if (p > 100000 && p < 1000000) {
                Console.Write("Input your affiliation: ");
                  string a = Console.ReadLine();
                  int p6 = 0;
                  int p5 = 0;
                  int p4 = 0;
                  int p3 = 0;
                  int n = 0;
                  
                     switch(a) {
                        case "CIA": 
                          int x6c = (int)p / 100000;
                          p6 = p - (x6c * 100000);
                          Console.WriteLine(p6);
                          int x5c = (int)p6 / 10000;
                          p5 = p6 - (x5c * 10000);
                          int x4c = (int)p5 / 1000;
                          p4 = p5 - (x4c * 1000);
                          int x3c = (int)p4 / 100;
                          p3 = p4 - (x3c * 100);
                          Console.WriteLine(p5);
                          break;
                        case "FBI":
                          int x6f = (int)p / 100000;
                          p6 = (int)x6f;
                          int x2f = (int)p / 10;
                          Console.WriteLine(p6);
                          break;
                        case "NSA":
                          while(p > 100){
                            p = p - (n * 100);
                            n = p / 100;
                          }
                          Console.WriteLine((int)p);
                          int x6n = (int)p / 10;
                          p6 = (int)x6n;
                          Console.WriteLine(p6);
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
