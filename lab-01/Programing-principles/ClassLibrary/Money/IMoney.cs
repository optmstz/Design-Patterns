using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MoneyPart
{
    public interface IMoney
    {
        int wholePart { get; set; }
        int fractionalPart { get; set; }

        string DisplayAmount();
    }
}
