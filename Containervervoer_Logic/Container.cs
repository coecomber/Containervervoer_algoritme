using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer_Logic
{
    public class Container
    {
        public int Weight;
        public bool IsCooled;
        public bool IsValuable;

        public Container(int weight, bool isCooled, bool isValuable)
        {
            Weight = weight;
            IsCooled = isCooled;
            IsValuable = isValuable;
        }

        public override string ToString()
        {
            string cooled = " | Niet gekoeld bewaren";
            string valuable = " | Geen waardevolle container";

            if (IsCooled)
            {
                cooled = " | Gekoeld bewaren";
            }

            if (IsValuable)
            {
                valuable = " | Waardevolle container";
            }

            return "Container gewicht: " + Weight + cooled + valuable;
        }
    }
}
