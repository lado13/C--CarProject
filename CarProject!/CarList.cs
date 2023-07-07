using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CarProject_
{
    internal class CarList 
    {
       
        private List<Car> carsList;
   

        public CarList()
        {
            carsList = new List<Car>()
            {
                new Car(){Color = "Black", Model = "Cruze", Number = Car.RandomCarNumber()},
                new Car(){Color = "Red", Model = "Mustang", Number = Car.RandomCarNumber()},
                new Car(){Color = "Black", Model = "Camry", Number = Car.RandomCarNumber()}
            };


        }





        public void AddCar()
        {
            Console.Write("Enter car color: ");
            string color = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter car model: ");
            string model = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter car number: ");
            string number = Console.ReadLine();
            string upper = number.ToUpper();    
            Console.WriteLine();

            Car car = new Car
            {
                Color = color,
                Model = model,  
                Number = upper 
            };

            carsList.Add(car);
            Console.WriteLine("Car added successfully!");

        }





        public void EditCar(string model)
        {
            Car car = carsList.Find(c => c.Model == model); 
            

            if (car != null)
            {
                Console.WriteLine("Enter new car color:");
                string newColor = Console.ReadLine();

                Console.WriteLine("Enter new car model:");
                string newModel = Console.ReadLine();

                Console.WriteLine("Enter new car number:");
                string newNumber = Console.ReadLine();
                string upperCase = newNumber.ToUpper(); 

                car.Color = newColor;
                car.Model = model;
                car.Number = upperCase;

                Console.WriteLine("Car edited successfully!");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }






        public void FIndCarByNumber(string number)
        {
            Car car = carsList.Find(c =>  c.Number == number);

            if (car != null)
            {
                Console.WriteLine($"Car found: Color: {car.Color}, Model: {car.Model}, Number: {car.Number}");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }



        public void DeleteCar(string modelName)
        {
            Car car = carsList.Find(x => x.Model == modelName);
            if (car != null)
            {
                carsList.Remove(car);
                Console.WriteLine("Car removed!");
            }
            else
            {
                Console.WriteLine("List are empty!");
            }
        }





        public void PrintAllCar()
        {
            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Color} {car.Model} {car.Number}");
            }
        }




        public static void ChoseMethod()
        {
            CarList car = new CarList();

            Console.WriteLine("If you want to add new car enter num => (1)");
            Console.WriteLine("If you want to print all car enter num => (2)");
            Console.WriteLine("If you want to find car by number => (3)");
            Console.WriteLine("If you want to edit car => (4)");
            Console.WriteLine("Quit => (q)");
            Console.WriteLine("------------------");


            while (true)
            {
                Console.Write("Enter : ");
                string chose = Console.ReadLine();

                if (chose == "1")
                {
                    car.AddCar();
                }
                else if (chose == "2")
                {
                    car.PrintAllCar();
                }
                else if (chose == "3")
                {
                    Console.Write("Find car by number: ");
                    string num = Console.ReadLine();
                    string upp = num.ToUpper();
                    car.FIndCarByNumber(upp);
                }
                else if (chose == "4")
                {
                    Console.Write("Enter model to edit: ");
                    string model = Console.ReadLine();
                    car.EditCar(model);
                }
                else if (chose == "5")
                {
                    Console.Write("Enter model to delete: ");
                    string model = Console.ReadLine();
                    car.DeleteCar(model);
                }
                else if (chose == "q")
                {
                    Console.WriteLine("Bay");
                    break;
                }
            }
        }




       


    }
}
