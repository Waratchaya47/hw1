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
                  int n = 0;
                  int p2 = 0;
                  
                     switch(a) {
                        case "CIA": 

                          
                          break;
                        case "FBI":
                          int x6f = (int)p / 100000;
                          p6 = (int)x6f;
                          int x2f = (int)p / 10;
                          if(p6 > 3 && p6 < 8) {
                            
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
