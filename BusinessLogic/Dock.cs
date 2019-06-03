using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Dock
    {
        public List<Container> ContainersToDistribute = new List<Container>();
        public List<Container> ContainersToDistributeLater = new List<Container>();
        public Ship CurrentShip = new Ship();

        public Dock()
        {
            ContainersToDistribute = new List<Container>();
            ContainersToDistributeLater = new List<Container>();
            CurrentShip = new Ship();
        }

        
    }
}
