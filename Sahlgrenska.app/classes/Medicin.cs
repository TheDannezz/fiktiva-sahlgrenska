

namespace Sahlgrenska.app.classes
{
   public class Medicin
    {
        public string Name;
        public Medicin(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
