using Containervervoer_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer_Logic
{
    public class Ship
    {
        private List<Row> Rows;

        private int MaxWeight;
        private int CurrentWeight;
        private int VerticalRows { get; set; }
        private int HorizontalRows { get; set; }

        private int LeftFrontWeight;
        private int RightFrontWeight;
        private int LeftBackWeight;
        private int RightBackWeight;

        public Ship(int verticalRows, int horizontalRows, int maxWeight)
        {
            LeftFrontWeight = 0;
            RightFrontWeight = 0;
            LeftBackWeight = 0;
            RightBackWeight = 0;

            CurrentWeight = 0;
            MaxWeight = maxWeight;
            VerticalRows = verticalRows;
            HorizontalRows = horizontalRows;
            Rows = new List<Row>();

            bool isFrontRow = true;

            for (int i = 0; i < horizontalRows; i++)
            {
                //Maakt nieuwe verticale row
                Row row = new Row();

                //Kijkt of dit de eerste rij is
                if (isFrontRow)
                {
                    row.IsFrontRow = true;
                    isFrontRow = false;
                }

                //Kijkt of dit de achterste rij is
                if (i == horizontalRows - 1)
                {
                    row.IsBackRow = true;
                }

                //Kijkt hoeveel piles er horizontaal in deze rij moeten komen
                //en voegt deze (nog lege) piles toe aan deze rij
                List<Pile> piles = new List<Pile>();
                for (int j = 0; j < verticalRows; j++)
                {
                    Pile pile = new Pile();
                    piles.Add(pile);
                }
                row.Piles = piles;

                Rows.Add(row);
            }
        }

        public bool TryToPlaceCooledContainer(Container container)
        {
            int rowsCount = 0;
            foreach (var r in Rows)
            {
                rowsCount++;
            }

            int leftRows = rowsCount / 2;

            foreach (var r in Rows)
            {
                if (r.IsFrontRow)
                {
                    int currentCount = 0;
                    foreach (var p in r.Piles)
                    {
                        //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                        if(p.PileWeightOnBottomContainer + container.Weight < 120000)
                        {
                            p.PlaceContainerOnPile(container);
                            CurrentWeight = CurrentWeight + container.Weight;
                            if (currentCount <= leftRows)
                            {
                                LeftFrontWeight = LeftFrontWeight + container.Weight;
                                return true;
                            }
                            else
                            {
                                RightFrontWeight = RightFrontWeight + container.Weight;
                                return true;
                            }
                        }
                        currentCount++;
                    }
                }
            }
            return false;
        }

        public bool TryToPlaceValuableContainer(Container container)
        {
            int rowsCount = 0;
            foreach(var r in Rows)
            {
                rowsCount++;
            }

            int leftRows = rowsCount / 2;

            foreach (var r in Rows)
            {
                if (r.IsBackRow)
                {
                    int currentCount = 0;
                    foreach (var p in r.Piles)
                    {
                        //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                        if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                        {
                            p.PlaceContainerOnPile(container);
                            CurrentWeight = CurrentWeight + container.Weight;
                            if (currentCount <= leftRows)
                            {
                                LeftBackWeight = LeftBackWeight + container.Weight;
                                return true;
                            }
                            else
                            {
                                RightBackWeight = RightBackWeight + container.Weight;
                                return true;
                            }
                        }
                        currentCount++;
                    }
                }

                if (r.IsFrontRow)
                {
                    int currentCount = 0;
                    foreach (var p in r.Piles)
                    {
                        //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                        if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                        {
                            p.PlaceContainerOnPile(container);
                            CurrentWeight = CurrentWeight + container.Weight;
                            if (currentCount <= leftRows)
                            {
                                LeftBackWeight = LeftBackWeight + container.Weight;
                                return true;
                            }
                            else
                            {
                                RightBackWeight = RightBackWeight + container.Weight;
                                return true;
                            }
                        }
                        currentCount++;
                    }
                }
            }
            return false;
        }

        public bool TryToPlaceRegularContainerRightFront(Container container)
        {
            int verticalRows = CalculateVerticalRows();
            int frontRows = verticalRows / 2;
            int looped = 0;

            foreach (var r in Rows)
            {
                if (looped >= frontRows)
                {
                    //Doe niks, dit is de achterkant dus hier kan de container niet geplaatst worden
                }
                else
                {
                    int piles = 0;
                    foreach (var p in r.Piles)
                    {
                        piles++;
                    }
                    int leftPiles = piles / 2;

                    int pilesLooped = 0;
                    foreach (var p in r.Piles)
                    {
                        if (pilesLooped >= piles)
                        {
                            //Dit is de rechter-voorkant. Probeer container te plaatsen
                            //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                            if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                            {
                                RightFrontWeight = RightFrontWeight + container.Weight;
                                p.PlaceContainerOnPile(container);
                                CurrentWeight = CurrentWeight + container.Weight;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool TryToPlaceRegularContainerRightBack(Container container)
        {
            int verticalRows = CalculateVerticalRows();
            int frontRows = verticalRows / 2;
            int looped = 0;

            foreach (var r in Rows)
            {
                if (looped >= frontRows)
                {
                    int piles = 0;
                    foreach (var p in r.Piles)
                    {
                        piles++;
                    }
                    int leftPiles = piles / 2;

                    int pilesLooped = 0;
                    foreach (var p in r.Piles)
                    {
                        if (pilesLooped >= piles)
                        {
                            //Dit is de rechter-achterkant. Probeer container te plaatsen
                            //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                            if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                            {
                                RightBackWeight = RightBackWeight + container.Weight;
                                p.PlaceContainerOnPile(container);
                                CurrentWeight = CurrentWeight + container.Weight;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool TryToPlaceRegularContainerLeftFront(Container container)
        {
            int verticalRows = CalculateVerticalRows();
            int frontRows = verticalRows / 2;
            int looped = 0;

            foreach (var r in Rows)
            {
                if (looped >= frontRows)
                {
                    //Doe niks, dit is de achterkant dus hier kan de container niet geplaatst worden
                }
                else
                {
                    int piles = 0;
                    foreach (var p in r.Piles)
                    {
                        piles++;
                    }
                    int leftPiles = piles / 2;

                    int pilesLooped = 0;
                    foreach (var p in r.Piles)
                    {
                        if (pilesLooped <= piles)
                        {
                            //Dit is de rechter-achterkant. Probeer container te plaatsen
                            //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                            if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                            {
                                LeftFrontWeight = LeftFrontWeight + container.Weight;
                                p.PlaceContainerOnPile(container);
                                CurrentWeight = CurrentWeight + container.Weight;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool TryToPlaceRegularContainerLeftBack(Container container)
        {
            int verticalRows = CalculateVerticalRows();
            int frontRows = verticalRows / 2;
            int looped = 0;

            foreach (var r in Rows)
            {
                if (looped >= frontRows)
                {
                    int piles = 0;
                    foreach (var p in r.Piles)
                    {
                        piles++;
                    }
                    int leftPiles = piles / 2;

                    int pilesLooped = 0;
                    foreach (var p in r.Piles)
                    {
                        if (pilesLooped <= piles)
                        {
                            //Dit is de rechter-achterkant. Probeer container te plaatsen
                            //Als door het plaatsen van deze container de 120ton niet overschreven zou worden
                            if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                            {
                                LeftBackWeight = LeftBackWeight + container.Weight;
                                p.PlaceContainerOnPile(container);
                                CurrentWeight = CurrentWeight + container.Weight;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool TryToAddContainerToMiddle(Container container)
        {
            int verticalRows = CalculateVerticalRows();
            //Als er een middelste verticale rij is
            if(verticalRows%2 == 1)
            {
                int rowsCount = 0;
                foreach (var r in Rows)
                {
                    rowsCount++;
                }
                int leftRows = rowsCount / 2;

                int loopCount = 0;

                foreach(var r in Rows)
                {
                    if(loopCount <= rowsCount)
                    {
                        foreach(var p in r.Piles)
                        {
                            if (p.PileWeightOnBottomContainer + container.Weight < 120000)
                            {
                                p.PlaceContainerOnPile(container);
                                return true;
                            }
                        }
                    }
                    loopCount++;
                }
            }
            return false;
        }

        public bool IsLeftSideAsHeavyOrHeavierThanRightSide()
        {
            //Checks if left side is as heavy or heavier than the right side of the ship
            //It's important to know that the right side is picked by looking at the ship
            //from above. Where the boat sails to is considered the front.
            if(LeftBackWeight + LeftFrontWeight >= RightBackWeight + RightFrontWeight)
            {
                return true;
            }

            return false;
        }

        public bool IsFrontSideAsHeavyOrHeavierThanBackSide()
        {
            //Checks if front side is as heavy or heavier than the back side
            if(LeftFrontWeight + RightFrontWeight >= LeftBackWeight + RightBackWeight)
            {
                return true;
            }

            return false;
        }

        private int CalculateVerticalRows()
        {
            int rows = 0;

            foreach (var i in Rows)
            {
                rows += 1;
            }

            return rows;
        }
    }
}
