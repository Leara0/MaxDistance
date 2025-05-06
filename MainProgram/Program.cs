using System.Device.Location;

using MainProgram;

var line = File.ReadAllLines("TacoBell-US-AL.csv");
var tacoBell =  line.Select(item =>Parse.ParseCSV(item)).ToArray();//@TODO study up on .Select()

double distance = 0;
var farthestA = "";
var farthestB = "";

for (int i = 0; i < line.Length; i++)
{
    var tacoBellA = tacoBell[i];
    var geoTacoBellA = new GeoCoordinate(tacoBellA.Location.Latitude, tacoBellA.Location.Longitude);
    for (int j = i+1; j < line.Length; j++)
    {
        var tacoBellB = tacoBell[j];
        var geoTacoBellB = new GeoCoordinate(tacoBellB.Location.Latitude, tacoBellB.Location.Longitude);
        
        if (geoTacoBellA.GetDistanceTo(geoTacoBellB) > distance)
        {
            distance = geoTacoBellA.GetDistanceTo(geoTacoBellB);
            farthestA = tacoBellA.Name;
            farthestB = tacoBellB.Name;
        }
    }
}

Console.WriteLine($"The two farthest Taco Bells are {farthestA} and {farthestB}. They are {distance:F2} meters apart.");
Console.WriteLine($"The distance in miles is {distance/1609.34:F2} miles.");
