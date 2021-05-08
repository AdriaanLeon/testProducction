using System;
using partOne.Models;

namespace partOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person1 = new Person(){
            //     Id = 1,
            //     Name = "Adrian",
            //     Age = 33,
            //     DNI = 031588
            // };
            
            // Console.WriteLine(person1.ShowDatapPerson());
            // Console.WriteLine(person1.IsBiggerAge());

            // var account = new Account(){
            //     Id = 1,
            //     Titular = "julio adrian leon",
            //     Quantity = 0
            // };
            // Console.WriteLine(account.InputQuantity(200));
            // Console.WriteLine(account.ExtraerQuantity(500));
            // Console.WriteLine(account.ShowDataAccount());
            var catPet = new Pet(){
                Name = "Chelsy",
                Age = 5,
                Raza = "Fina",
                TypeAnimal = "Cat"
            };
            Console.WriteLine(catPet.ShowDataPet());
        }
    }
}
