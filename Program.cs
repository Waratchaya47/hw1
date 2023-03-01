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
                     switch(a) {
                        case "CIA": 
                          money = 20;
                          break;
                        case "FBI":
                          money = 25;
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
