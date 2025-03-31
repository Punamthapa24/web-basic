public class Room
{
    public Room()
    {

    }
    //constructor (Object create garda)
    public Room(string color, byte f, double l, double w, double h)
    {
        paintColor = color;
        floor = f;
        lengthFt = l;
        widthFt = w;
        heigthFT = h;
    }
    // Fields
    public double widthFt;
    public double lengthFt;
    public double heigthFT;
    public string paintColor;   //Access modifier(Public,private etc)
    public byte floor;
    //methods
    public void DisplayInfo()
    {
        var info = $"Hey guys we have a room in floor {floor} which is painted {paintColor}. It's dimension is {lengthFt}x{widthFt}x{heigthFT}.";
        Console.WriteLine(info);
    }
}