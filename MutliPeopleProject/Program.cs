using System;

namespace MutliPeopleProject {
    
    class Program {
        
        static void Main(string[] args) {
            
            bool checker = false;
            int counter = 1;

            for (int i = 1; i <= 690; i++) {
                
                if (!checker) {
                    Console.WriteLine(counter + ". false");
                    checker = true;
                } else {
                    Console.WriteLine(counter + ". true");
                    checker = false;
                }
                counter++;
            }
        }
    }
}