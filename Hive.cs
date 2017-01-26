using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Animated_bees
{
    class Hive
    {
        public double Honey { get; private set; }
        private Dictionary<string, Point> locations;
        private int beeCount;
        private const int startBeesVal = 6;
        private const double startHoney = 3.2;
        private const double maxHoney = 15.0;
        private const double kCreatingHoney = 0.25;
        private const int maxBeesVal = 8;
        private const double minHoneyToCreateBees = 4.0;
        public Point GetLocation(String nameLocation)
        {

            if (locations.Keys.Contains(nameLocation)) return locations[nameLocation];
            else throw new ArgumentException("There is no such location "+nameLocation);
        }

        private void InitializeLocations() 
        {
            locations.Add("Вход",new Point(600,100));
            locations.Add("Питомник", new Point(95, 174));
            locations.Add("Фабрика", new Point(157, 98));
            locations.Add("Выход", new Point(194, 213));
        
        }
        public void AddBee(Random random)
        { 
        //if (beeCount<maxBeesVal)&(Honey>minHoneyToCreateBees) {};//Сделать пчелу
        
        }
        public bool AddHoney(double nectar) { return true; }
        public bool ConsumeHoney(double amount) { return true; }
        public void Go() { }
        public Hive()
        {
            Random random=new Random ();
            Honey = startHoney;
            while (beeCount < startBeesVal)
            {
                AddBee(random);
                beeCount++;
            }
            InitializeLocations();
        }




    }
}
