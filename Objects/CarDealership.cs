using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _make;
    private string _model;
    private string _year;
    private string _miles;
    private string _description;
    private int _id;
    private static List<Car> _instances = new List<Car> {};

    public Car (string make, string model, string year, string miles, string description)
    {
      _make = make;
      _model = model;
      _year = year;
      _miles = miles;
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetMake()
    {
      return _make;
    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public string GetYear()
    {
      return _year;
    }
    public void SetYear(string newYear)
    {
      _year = newYear;
    }
    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public int GetId()
    {
      return _id;
    }
    public void SetId(int newID)
    {
      _id = newID;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Car Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void BuyCar(int removeID)
    {
      _instances.RemoveAt(removeID - 1);
      for (int i = 0; i < _instances.Count; i++)
      {
        _instances[i].SetId(i+1);
      }
    }
  }
}
