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

            foreach (var cooledContainer in CooledContainers)
            {
                if (!ShipToFill.TryToPlaceCooledContainer(cooledContainer))
                {
                    //Toevoegen van container aan koeling niet gelukt. Moet met het volgende schip mee.
                    ContainersForAnotherShip.Add(cooledContainer);
                }
            }

            foreach(var valuableContainer in ValuableContainers)
            {
                if (valuableContainer.IsValuable)
                {
                    if (!valuableContainer.IsCooled)
                    {
                        if (ShipToFill.TryToPlaceValuableContainer(valuableContainer))
                        {
                            //Toevoegen van container niet gelukt. Moet met het volgende schip mee.
                            ContainersForAnotherShip.Add(valuableContainer);
                        }
                    }
                }
            }

            foreach(var regularContainer in ContainersToDistribute)
            {
                bool placedContainer = false;

                //Is het een reguliere container?
                if (!regularContainer.IsCooled && !regularContainer.IsValuable)
                {
                    //Is de linkerkant momenteel zwaarder of even zwaar als de rechterkant?
                    if (ShipToFill.IsLeftSideAsHeavyOrHeavierThanRightSide())
                    {
                        //Front side is heavier
                        if (ShipToFill.IsFrontSideAsHeavyOrHeavierThanBackSide())
                        {
                            if (ShipToFill.TryToPlaceRegularContainerRightBack(regularContainer))
                            {
                                placedContainer = true;
                            }
                        }
                        else
                        {
                            if (ShipToFill.TryToPlaceRegularContainerRightFront(regularContainer))
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
                            if (ShipToFill.TryToPlaceRegularContainerLeftBack(regularContainer))
                            {
                                placedContainer = true;
                            }
                        }
                        else
                        {
                            if (ShipToFill.TryToPlaceRegularContainerLeftFront(regularContainer))
                            {
                                placedContainer = true;
                            }
                        }
                    }

                    if (!placedContainer)
                    {
                        if (!ShipToFill.TryToAddContainerToMiddle(regularContainer))
                        {
                            //Container kon nergens geplaats worden. Volgende schip opnieuw proberen.
                            ContainersForAnotherShip.Add(regularContainer);
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
