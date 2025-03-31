public class Lake
{
    public  Lake() {

    }
    public Lake(string name, string location, float a, float l, float w, float ad, double s)
    {
        nameOfLake =  name;
        locationName = location;
        altitude = a;
        length = l;
        width = w;
        averageDepth = ad;
        surfaceArea = s;
    }
     public string? nameOfLake; 
     public string? locationName;
    public float altitude;   //ft
    public float length;    //kilometer
    public float width;     //kilometer
    public float averageDepth;    //ft
     public double surfaceArea;   //kilometersquare

    public void DisplayDetails()
    {
        var details = $"Hello Everyone! This is {nameOfLake} which is located at {locationName} of Nepal with it's dimension {altitude}x{length}x{width}x{averageDepth}x{surfaceArea}";
        Console.WriteLine(details);
    }
}   