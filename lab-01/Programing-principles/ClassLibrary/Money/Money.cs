using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MoneyPart
{
    public class Money : IMoney
    {
        public int wholePart { get; set; }
        public int fractionalPart { get;  set; }


        public Money(int wholePart, int fractionalPart)
        {
            this.wholePart = wholePart + fractionalPart / 100;
            this.fractionalPart = fractionalPart % 100;
        }

        public virtual string DisplayAmount()
        {
            return $"{wholePart}.{fractionalPart}";
        }
    }
}
