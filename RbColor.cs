using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbTreeLibrary
{
    public enum RbColor
    {
        None = -1, // only for criteria
        Red = 0,
        Black = 1,
        DoubleBlack_Red = 2, // temparary state
        DoubleBlack = 3 // temporary state
    }
}
