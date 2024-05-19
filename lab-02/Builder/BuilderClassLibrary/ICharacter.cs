using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public interface ICharacter
    {
        double Height { get; set; }
        string Build { get; set; }
        string HairColor { get; set; }
        string EyeColor { get; set; }
        string Clothing { get; set; }
        List<string> Inventory { get; set; }
    }
}
