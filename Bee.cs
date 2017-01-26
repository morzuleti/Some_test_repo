using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Animated_bees
{
    class Bee
    {
        private const double HoneyConsumed = 0.5;
        private const int MoveRate = 3;
        private const double MinimumFlowerNectar = 1.5;
        private const int CareerSpan = 1000;

        public BeeState CurrentState { get; private set; }
        public int Age {get; private set;}
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }

        private Point location;
        public Point Location { get { return location; } }

        private int ID;
        private Flower destinationFlower;
        public Bee (int id, Point location)
        {
            this.ID = id;
            Age = 0;
            this.CurrentState = BeeState.Idle;
            this.location = location;
            InsideHive = true;
            NectarCollected = 0;
        
        }
        public void go(Random random)
        {
            Age++;
            switch (CurrentState)
            {
                case BeeState.Idle:  if (Age > CareerSpan) CurrentState = BeeState.Retired; 
                                    else  
                                        { //something to do
                                         } break;
                case BeeState.FlyingTOFlower: //летим к цветку} 
                    break;
                case BeeState.GatheringNectar:
                    {
                        double nectar = destinationFlower.HarvestNectar();
                        if (nectar > 0) NectarCollected += nectar;
                        else CurrentState = BeeState.ReturningToHive;
                } 
                    break;
                case BeeState.MakingHoney:
                    {
                        if (NectarCollected < 0.5) { NectarCollected = 0; CurrentState = BeeState.Idle; }
                        else { //Переработка нектара в мед
                        }
                
                     } 
                    break;
                case BeeState.ReturningToHive: 
                    {
                        if (!InsideHive) { }
                        else { }
                
                    } 
                    break;
                case BeeState.Retired: { } 
                    break;
            
            }
        }

        private bool MoveTowardsLocation(Point destination)
        { 
        
        if ((Math.Abs(destination.X-location.X)<=MoveRate)&&(Math.Abs(destination.Y-location.Y)<=MoveRate )) return true ;
        if (destination.X > location.X) location.X += MoveRate; else location.X -= MoveRate;
        if (destination.Y > location.Y) location.Y += MoveRate; else location.Y -= MoveRate;
        return false;

        }

    }
}
