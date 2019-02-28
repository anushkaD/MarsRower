﻿namespace ExploreMars
{
    public class EastFacingRover : Rover
    {
        public EastFacingRover(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "E";
        }

        public override void MoveOneGridPoint()
        {
            X += 1;
        }

        public override Rover TurnLeft()
        {
            return new NorthFacingRover(X, Y);
        }

        public override Rover TurnRight()
        {
            return new SouthFacingRover(X, Y);
        }
    }
}