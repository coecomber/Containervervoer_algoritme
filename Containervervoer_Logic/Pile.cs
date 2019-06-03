using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer_Logic
{
    public class Pile
    {
        public List<Container> Containers;
        public int PileWeightOnBottomContainer;

        public Pile()
        {
            PileWeightOnBottomContainer = 0;
            Containers = new List<Container>();
        }

        public void PlaceContainerOnPile(Container container)
        {
            int ContainerAmount = 0;
            foreach(var i in Containers)
            {
                ContainerAmount += 1;
            }

            if(ContainerAmount > 0)
            {
                PileWeightOnBottomContainer = PileWeightOnBottomContainer + container.Weight;
                Containers.Add(container);
            }

            if(ContainerAmount == 0)
            {
                Containers.Add(container);
            }
        }
    }
}
