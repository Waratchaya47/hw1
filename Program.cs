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
                  int p2 = 0;
                  
                     switch(a) {
                        case "CIA": 

                          
                          break;
                        case "FBI":
                          int x6f = (int)p / 100000;
                          p6 = (int)x6f;
                          if(p6 > 3 && p6 < 8) {
                            p = p - (x6f * 100000);
                            int x5f = (int)p / 10000;
                            p5 = p - (x5f * 10000);
                            int x4f = (int)p5 / 1000;
                            p4 = p5 - (x4f * 1000);
                            int x3f = (int)p4 / 100;
                            p3 = (int)x3f;
                            if(p3 % 2 == 0) {
                              if(p3 != 6){
                                p = p - (x6f * 100000);
                                int x5f3 = (int)p / 10000;
                                p5 = (int)x5f3;
                                Console.Write(p5);
                              }
                            }

                            }
                          
                          break;
                        case "NSA":
                          while(p > 100){
                            p = p - (n * 100);
                            n = p / 100;
                          }
                          Console.WriteLine((int)p);
                          int x2n = (int)p / 10;
                          p2 = (int)x2n;
                          Console.WriteLine(p2);
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
