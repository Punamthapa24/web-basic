public class Glacial : Lake
{
    public Glacial(string n, double a, double d, string s, double w, string eco)
    {
        Name = n;
        Area = a;
        Depth = d;
        SedimentContent = s;
        WaterTemperature = w;
        Ecosystem = eco;
    }
    public string Name;
    public double Area; // in square kilometers
    public double Depth;// in meters
     public string SedimentContent; // e.g., High, Medium, Low

    public double WaterTemperature; // in Celsius
    public string Ecosystem ; // e.g., Flora and Fauna specifics

    public void DisplayGlacialFeatures()
    {
        var glacial = $"Hi everyone! Here we have extra features in {Name} whhose area and depth are {Area}x{Depth} with {SedimentContent} sediment content. Here water temperature is {WaterTemperature} and the ecosystem {Ecosystem}";
        Console.WriteLine(glacial);
    }
}