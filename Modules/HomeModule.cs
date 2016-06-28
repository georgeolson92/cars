using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/lot"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["lot.cshtml", allCars];
      };
      Get["/car/new"] = _ => {
        return View["sell_form.cshtml"];
      };
      // Get["/cars/{id}"] = parameters => {
      //   Car car = Cars.Find(parameters.id);
      //   return View["car.cshtml", car];
      // };
      Post["/sellCar"] = _ => {
        Car newCar = new Car(Request.Form["new-make"],Request.Form["new-model"],Request.Form["new-year"],Request.Form["new-miles"]);
        List<Car> allCars = Car.GetAll();
        return View["lot.cshtml", allCars];
      };
      // Post["/sell"] = _ => {
      //   List<Task> allTasks = Task.GetAll();
      //   ////remove car by ID?
      //   return View["sell.cshtml", allTasks];
      // };
    }
  }
}
