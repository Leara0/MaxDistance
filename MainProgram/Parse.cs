namespace MainProgram;

public class Parse
{
    public static ITrackable ParseCSV(string line)
    {
        var logger = new TacoLogger();
        logger.LogInfo($"Parsing {line}");
        var data = line.Split(',');
        if (data.Length < 3)
        {
            logger.LogError($"Less than 3 cells in this line. Null will be returned.");
            return null;
        }
        
        var latitute = double.Parse(data[0]);
        var longitude = double.Parse(data[1]);
        var name = data[2];

        var location = new TacoBell(name, new Point(latitute, longitude));
      
        logger.LogInfo($"Successfully parsed: {line}");
        
        return location;
    }
}