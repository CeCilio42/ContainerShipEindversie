﻿using System;


namespace ContainerShipEindversie
{
    public class Container
    {
        public int Weight { get; private set; }
        private int MaxWeight = 30;
        public int MinWeight { get; private set; } = 4;

        public ContainerTypes ContainerType { get; private set; }


        public Container(int weight, int type)
        {
            Weight = SetWeight(weight);
            ContainerType = (ContainerTypes)type;
        }

        public enum ContainerTypes
        {
            Normal = 1,
            Valuable = 2,
            Coolable = 3,
            CoolableValuable = 4
        }

        private int SetWeight(int weight)
        {
            if (weight < MinWeight)
            {
                throw new Exception("Weight is mininum is 4 tons");
            }
            else if (weight > MaxWeight)
            {
                throw new Exception("Weight maximun is 30 tons");
            }

            return weight;
        }
    }
}