using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Row
    {
        public RowSide RowSide { get; set; }
        public List<Pile> Piles { get; set; }

        public Row(RowSide rowSide)
        {
            RowSide = rowSide;
            Piles = new List<Pile>();
        }
    }
}
