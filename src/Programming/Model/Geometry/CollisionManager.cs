using System;

namespace Programming.Model.Geometry
{
    public class CollisionManager
    {
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            return rect1.Center.X < rect2.Center.X + rect2.Width &&
                rect1.Center.X + rect1.Width > rect2.Center.X &&
                rect1.Center.Y < rect2.Center.Y + rect2.Height &&
                rect1.Height + rect1.Center.Y > rect2.Center.Y;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
