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
      Get["/cars/{id}"] = parameters => {
        Car car = Car.Find(parameters.id);
        return View["car.cshtml", car];
      };
      Post["/sellCar"] = _ => {
        Car newCar = new Car(Request.Form["new-make"],Request.Form["new-model"],Request.Form["new-year"],Request.Form["new-miles"],Request.Form["new-description"]);
        List<Car> allCars = Car.GetAll();
        return View["lot.cshtml", allCars];
      };
      Post["/buy"] = _ => {
        int _id = Request.Form["id"];
        Car.BuyCar(_id);
        List<Car> allCars = Car.GetAll();
        return View["lot.cshtml", allCars];
      };
    }
  }
}
