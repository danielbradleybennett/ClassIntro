using System;

namespace ClassIntro {
    class Program {
        static void Main (string[] args) {

            Car myFordbronco = new Car (40000, "Ford", "Bronco", 1982);
            // myFordbronco.Make = "Ford";
            // myFordbronco.Model = "Bronco";
            // myFordbronco.Year = 1982;

            Car mySubaru = new Car (10000) {
                Make = "Subarau",
                Model = "Outback",
                Year = 1999
            };

            Console.WriteLine (mySubaru.Description);
            Console.WriteLine (myFordbronco.Description);

            myFordbronco.Drive (9999);
            Console.WriteLine ($"Bronco needs service: {myFordbronco.NeedsMaintenance}");

            myFordbronco.Drive (70);
            Console.WriteLine ($"Bronco needs service: {myFordbronco.NeedsMaintenance}");

            myFordbronco.Service (true);
        }
    }
}