
namespace Sahlgrenska.app.classes
{
    public class Equipment
    {
        public string Name;
        public Equipment (string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
