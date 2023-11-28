using System;
namespace Assignment
{
    public class Fan
    {
        public int speed { get; set; }
        public double radius { get; set; }
        public string color { get; set; }

        public void Fan()
        {
            this.setSpeed(1);
            this.setRadius(1.53);
            this.setColor("green");
        }

        public void Fan(double newRadius)
        {
            this.setRadius(newRadius);
        }

        public String toString()
        {
            return String.Format("A %.2f inch {0} fan at a speed of {1}",
            this.getRadius(), this.getColor(), this.getSpeed());
        }

    }
}