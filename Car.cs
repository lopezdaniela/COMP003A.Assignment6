namespace COMP003A.Assignment6 
{
    /// <summary>
    /// car extemds the vehicle class 
    /// </summary>

    internal class Car : Vehicle 
    {
    
    /***** constructors section *****/
    // by default, a class has a default constructor that does not take any parameters 
    // therefore, you do not have to explicitly create one 

    /***** methods section *****/
    /// <summary>
    /// overrides the base vehicle's definition for GetInfo ()
    /// </summary>

    public override void GetInfo ()
    {
    Console.WriteLine ($"I'm a {nameof(Car)}");
    Console.WriteLine ("I don't want to disclose my information.");
    }

}
}