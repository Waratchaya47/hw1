using System;
namespace hw {
    class program {
        static void Main(string[] args) {
            Console.Write("Input Password (6 number): ");
            int pass = int.Parse(Console.ReadLine());
           
            if (pass > 100000 && pass < 1000000) {
                Console.Write("Input your affiliation: ");
                  string a = Console.ReadLine();
                  int p6 = 0;
                  int p5 = 0;
                  int p4 = 0;
                  int p3 = 0;
                  int p2 = 0;
                 
                  
                     switch(a) {
                        case "CIA": 
                          int x6c = (int)pass / 100000;
                          p6 = pass - (x6c * 100000);
                          int x5c = (int)p6 / 10000;
                          p5 = p6 - (x5c * 10000);
                          int x4c = (int)p5 / 1000;
                          p4 = p5 - (x4c * 1000);
                          int x3c = (int)p4 / 100;
                          p3 = p4 - (x3c * 100);
                          int x2c = (int)p3 / 10;
                          p2 = p3 - (x2c * 10);
                          if(p2 % 3 == 0) {
                            int x6c2 = (int)pass / 100000;
                            p6 = pass - (x6c2 * 100000);
                            int x5c2 = (int)p6 / 10000;
                            p5 = p6 - (x5c2 * 10000);
                            int x4c2 = (int)p5 / 1000;
                            p4 = p5 - (x4c2 * 1000);
                            int x3c2 = (int)p4 / 100;
                            p3 = p4 - (x3c2 * 100);
                            int x2c2 = (int)p3 / 10;
                            p2 = (int)x2c2;
                            if(p2 == 1) {
                              Console.WriteLine("False"); 
                            } else if (p2 == 3){
                              Console.WriteLine("False");
                            } else if (p2 == 5){
                              Console.WriteLine("False");
                            } else { 
                              int x6c3 = (int)pass / 100000;
                              p6 = pass - (x6c3 * 100000);
                              int x5c3 = (int)p6 / 10000;
                              p5 = p6 - (x5c3 * 10000);
                              int x4c3 = (int)p5 / 1000;
                              p4 = (int)x4c3;
                              if(p4 >= 6 && p4 != 8) {
                                Console.WriteLine("True"); }   
                           }
                          } Console.WriteLine("False");
                          break;
                        
                        case "FBI":
                          int x6f = (int)pass / 100000;
                          p6 = (int)x6f;
                          if(p6 > 3 && p6 < 8) {
                            p6 = pass - (x6f * 100000);
                            int x5f = (int)p6 / 10000;
                            p5 = p6 - (x5f * 10000);
                            int x4f = (int)p5 / 1000;
                            p4 = p5 - (x4f * 1000);
                            int x3f = (int)p4 / 100;
                            p3 = (int)x3f;
                            if(p3 % 2 == 0) {
                              if(p3 != 6){
                                p6 = pass - (x6f * 100000);
                                int x5f3 = (int)p6 / 10000;
                                p5 = (int)x5f3;
                                if(p5 % 2 != 0){
                                  Console.WriteLine("True");
                                }else {
                                  Console.WriteLine("False"); }
                              } else { 
                                Console.WriteLine("False"); }
                            } else{
                              Console.WriteLine("False"); }
                            } else{
                            Console.WriteLine("False"); }
                          break;
                        
                        case "NSA":
                          int x6n = (int)pass / 100000;
                          p6 = pass - (x6n * 100000);
                          int x5n = (int)p6 / 10000;
                          p5 = p6 - (x5n * 10000);
                          int x4n = (int)p5 / 1000;
                          p4 = p5 - (x4n * 1000);
                          int x3n = (int)p4 / 100;
                          p3 = p4 - (x3n * 100);
                          int x2n = (int)p3 / 10;
                          p2 = p3 - (x2n * 10);
                          if(30 % p2 == 0) {
                            p6 = pass - (x6n * 100000);
                            int x5n1 = (int)p6 / 10000;
                            p5 = p6 - (x5n1 * 10000);
                            int x4n1 = (int)p5 / 1000;
                            p4 = p5 - (x4n1 * 1000);
                            int x3n1 = (int)p4 / 100;
                            p3 = (int)x3n1;
                            if(p3 % 3 == 0 && p3 % 2 != 0) {
                              p3 = p4 - (x3n1 * 100);
                              int x2n1 = (int)p3 /10;
                              if(x6n == 7 || x5n1 == 7 || x4n1 == 7 || x3n1 == 7 || p2 ==7 || x2n1 == 7){
                                Console.WriteLine("True");
                              } else {
                                Console.WriteLine("False"); }
                            } else {
                              Console.WriteLine("False"); }
                          } else {
                            Console.WriteLine("False"); }
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
