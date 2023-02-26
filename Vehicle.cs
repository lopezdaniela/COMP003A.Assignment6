namespace COMP003A.Assignment6 
{
    /// <summary>
    /// abstracts describe a contract but does not provide a full implementaiton of the contract.
    /// read 
    /// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>

abstract class Vehicle : IVehicle 
{
    /***** fields section *****/
    // note: in almost all programming languages, you would typically pair a field with a property
    // this is not a requirement in C# because it offers auto-property 
    private string _brand;
    private string _model;
    private int _numberOfWheels;

    /***** constructors section *****/
    /// <summary>
    ///default constructor
    /// </summary>

    public Vehicle ()
    {}

    /// <summary>
    /// constructor that takes three parameters: brand, model, numberofwheels
    /// </summary>
    /// <param name = "brand"> string input for brand name </param>
    /// <param name = "model"> string input for model name </param>
    /// <param name = "numberofwheels" > integer input for number of wheels </param>
    public Vehicle (string brand, string model, int numberOfWheels)
    {
    Brand = brand;
    Model = model;
    NumberOfWheels = numberOfWheels; 
    }

    /***** properties section *****/
    /// <summary>
    /// retrieve/store brand information
    /// </summary>
    public string Brand
    {
    get {return _brand;}
    set {_brand = value;}
    }

    /// <summary>
    /// retrieve/store model information 
    /// </summary>
    public string Model
    {
    get {return _model;}
    set {_model = value;}
    }

    /// <summary>
    /// retrieve/store number of wheels information 
    /// </summary>

    public int NumberOfWheels
    {
        get {return _numberOfWheels;}
        set {_numberOfWheels = value;}
    }

    /***** methods section *****/
    /// <summary>
    /// prints the brand, model, and number of wheels information
    /// </summary>

    public virtual void GetInfo ()
    {
    Console.WriteLine ($"Brand: {Brand}");
    Console.WriteLine ($"Model: {Model}");
    Console.WriteLine ($"Number of Wheels: {NumberOfWheels}");
    }

}
}