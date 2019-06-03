using Containervervoer_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer_Logic
{
    public class Row
    {
        public List<Pile> Piles;

        public bool IsFrontRow;
        public bool IsBackRow;

        public Row()
        {
            Piles = new List<Pile>();
        }

    }
}
