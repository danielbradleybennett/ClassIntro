using System;

namespace ClassIntro {
  public class Car {

    // Field
    // Fields dont have a get; set; and are typically private
    private int _milesDriven = 0;
    // Properties
    // Properties have a get; set; and are typically public
    public string Make { get; set; }
    public string Model { get; set; }

    public int Year { get; set; }

    public bool NeedsMaintenance { get; set; } = false;
    public bool IsClean { get; set; } = false;

    // Computed Property
    // Its a read only property. cannot be set. 
    public string Description {
      get {
        return $"{Year} {Make} {Model}";
      }
    }

    // Methods
    public void Drive (int miles) {
      _milesDriven += miles;

      if (_milesDriven > 10000) {
        NeedsMaintenance = true;
      }
    }
    public void Service () {
      NeedsMaintenance = false;
    }
    // Method Overloading
    // shares a method name, but has different arguments
    public void Service (bool addCleaningService) {
      NeedsMaintenance = false;
      IsClean = true;
    }
    // This is a constructor. It doesnt have a return type and the name of the method is the same as the name of the class
    public Car (int milesDriven) {

      _milesDriven = milesDriven;
      Console.WriteLine ("Inside the constructor");
    }
    public Car (int milesDriven, string make, string model, int year) {

      _milesDriven = milesDriven;
      Make = make;
      Model = model;
      Year = year;
    }

  }
}