namespace MainProgram;

public class Parse
{
    public static ITrackable ParseCSV(string line)
    {
        var data = line.Split(',');
        var latitute = double.Parse(data[0]);
        var longitude = double.Parse(data[1]);
        var name = data[2];

        var location = new TacoBell();
        location.Name = name;
        location.Location = new Point();
        location.Location.Latitude = latitute;
        location.Location.Longitude = longitude;
        
        return location;
    }
}