namespace COMP003A.Assignment6 
{
    /// <summary>
    /// truck extends the vehicle class 
    /// </summary>

    internal class Truck : Vehicle 
    {

    /***** fields section *****/
    private double _sizeOfTruckBed;

    /***** constructors section *****/
    /// <summary>
    /// constructor that takes 4 parameters: truckBrand, truckModel, truckNumberOfWheels, and sizeOfTruckBed
    /// it reuses the bass class (Vehicle)'s constructor that takes 3 parameters: brand, model, numberofwheels
    /// </summary>
    /// <param name = "truckBrand"></param>
    /// <param name = "truckModel"></param>
    /// <param name = "truckNumberOfWheels"></param>
    /// <param name = "sizeOfTruckBed"></param>
    public Truck (string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base (truckBrand, truckModel, truckNumberOfWheels)
    {
    SizeOfTruckBed = sizeOfTruckBed;
    }

    /***** properties section *****/
    public double SizeOfTruckBed
    {
    get {return _sizeOfTruckBed;}
    set {_sizeOfTruckBed = value;}
    }

    /***** methods section *****/
    /// <summary>
    /// overrides the base vehicle's definition for GetInfo () 
    /// calls the base vehicle GetInfo () but adds on it
    /// </summary>

    public override void GetInfo ()
    {
    Console.WriteLine ($"I'm a {nameof(Truck)}");
    base.GetInfo ();
    Console.WriteLine ($"I also have a {SizeOfTruckBed} ft truck bed");
    }
 
}
}