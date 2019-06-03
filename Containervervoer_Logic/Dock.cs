using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer_Logic
{
    public class Dock
    {
        private List<Container> ContainersToDistribute;
        private List<Container> ContainersForAnotherShip;
        private Ship ShipToFill;

        public Dock()
        {
            ContainersToDistribute = new List<Container>();
            ContainersForAnotherShip = new List<Container>();
        }

        public void DistributeContainersToShip()
        {
            List<Container> CooledContainers = ContainersToDistribute.FindAll(c => c.IsCooled);
            List<Container> ValuableContainers = ContainersToDistribute.FindAll(c => c.IsValuable);

            foreach (var cc in CooledContainers)
            {
                if (!ShipToFill.TryToPlaceCooledContainer(cc))
                {
                    //Toevoegen van container aan koeling niet gelukt. Moet met het volgende schip mee.
                    ContainersForAnotherShip.Add(cc);
                }
            }

            foreach(var vc in ValuableContainers)
            {
                if (vc.IsValuable)
                {
                    if (ShipToFill.TryToPlaceValuableContainer(vc))
                    {
                        //Toevoegen van container niet gelukt. Moet met het volgende schip mee.
                        ContainersForAnotherShip.Add(vc);
                    }
                }
            }

            foreach(var c in ContainersToDistribute)
            {
                bool placedContainer = false;

                //Is het een reguliere container?
                if (!c.IsCooled && !c.IsValuable)
                {
                    //Is de linkerkant momenteel zwaarder of even zwaar als de rechterkant?
                    if (ShipToFill.IsLeftSideAsHeavyOrHeavierThanRightSide())
                    {
                        //Front side is heavier
                        if (ShipToFill.IsFrontSideAsHeavyOrHeavierThanBackSide())
                        {
                            if (ShipToFill.TryToPlaceRegularContainerRightBack(c))
                            {
                                placedContainer = true;
                            }
                        }
                        else
                        {
                            if (ShipToFill.TryToPlaceRegularContainerRightFront(c))
                            {
                                placedContainer = true;
                            }                            
                        }
                    }
                    else
                    //Right side is heavier
                    {
                        //Font side is heavier
                        if (ShipToFill.IsFrontSideAsHeavyOrHeavierThanBackSide())
                        {
                            if (ShipToFill.TryToPlaceRegularContainerLeftBack(c))
                            {
                                placedContainer = true;
                            }
                        }
                        else
                        {
                            if (ShipToFill.TryToPlaceRegularContainerLeftFront(c))
                            {
                                placedContainer = true;
                            }
                        }
                    }

                    if (!placedContainer)
                    {
                        if (!ShipToFill.TryToAddContainerToMiddle(c))
                        {
                            //Container kon nergens geplaats worden. Volgende schip opnieuw proberen.
                            ContainersForAnotherShip.Add(c);
                        }
                    }
                }
            }
        }

        public Ship GetShip()
        {
            return ShipToFill;
        }

        public void SetShipSize(int verticalRows, int horizontalRows, int maxWeight)
        {
            ShipToFill = new Ship(verticalRows, horizontalRows, maxWeight);
        }

        public void AddContainerToContainersToDistributeList(Container container)
        {
            ContainersToDistribute.Add(container);
        }

        public List<Container> GetContainersToDistribute()
        {
            return ContainersToDistribute;
        }
    }
}
