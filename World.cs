using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Animated_bees
{
    class World
    {
        private const double NectarHarvestedPerNewFlower = 50.0;
        private const int FieldMinX = 15;
        private const int FieldMinY = 177;
        private const int FieldMaxX = 690;
        private const int FieldMaxY = 290;

        public Hive Hive {get; private set;}
        public List<Bee> Bees { get; private set; }
        public List<Flower> Flowers { get; private set; }

        private void AddFlower(Random random)
        {
            Point pointOfFlower = new Point(random.Next(FieldMinX, FieldMaxX),
                random.Next(FieldMinY, FieldMaxY));
            Flowers.Add(new Flower(pointOfFlower, random));

        }

        public World()
        {
            Bees = new List<Bee>();
            Flowers = new List<Flower>();
            Random random = new Random();
            for (int i = 0; i < 10; i++) { AddFlower(random); }
        
        }

    }
}
