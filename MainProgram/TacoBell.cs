namespace MainProgram;

public struct TacoBell:ITrackable
{
    public string Name { get; set; }
    public Point Location { get; set; }

    public TacoBell( String name, Point location )
    {
        Name = name;
        Location = location;
    }
}