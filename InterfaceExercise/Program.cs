using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /*DONE Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car() { HasTrunk=true,Wheels=4,Doors=4,seats=5,Make="Ford",Logo= "ford with blue background",Name="focus" };
            var truck = new Truck() { CanTow = true,seats=2,Doors=2,Wheels=4,HasFlatBed=true, Make="ford", Logo="ford with blue background",Name="f150"};
            var suv=new Suv() { Name ="rav4",Doors=4, Wheels=4,seats=7,HasCargo=true,Logo="a T within an oval",Make="Toyata"};

            var vehicle = new List<IVehicle>() { truck, suv, car };
            
            foreach(var v in vehicle)
            {
                Console.WriteLine($" vehicle company name:{v.Make},this Vehicle has these features:{v.Doors} Doors, {v.seats} seats , {v.Wheels} Wheels ");
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
