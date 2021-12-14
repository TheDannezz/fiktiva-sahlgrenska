namespace Sahlgrenska.app.classes
{
    public class Room
    {
        public string Name;
        public Room(string name)
        {
            Name = name;
        }

        public override string ToString( )
        {
            return Name;
        }
    }
}