using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;

namespace Creatures_Creatures_Creatures_
{
    // This class will have the position, speed, "body", and movement method of all the blobs in the game!
    // Perhaps this will be a Base class, with a Derived class for *mega blobs* or *boss blobs*
    // OR maybe there can be blobs of different types, which would each have slightly different behavior from one another: different methods of attack, different movement mechanics
    
    public class Blob
    {
        // These x and y positions are basically like it's "spawn" coordinates
        public double xPos;
        public double yPos;
        public double Speed;
        public Ellipse Body;

        // Constructor for all the blobs ever! 
        public Blob(double x, double y, double speed, Color color)
        {
            x = xPos;
            y = yPos;
            speed = Speed;
            Body = new Ellipse
            {
                Width = 40,
                Height = 40,
                Fill = new SolidColorBrush(color)
            };
        }
        public Blob()
        {

        }


        // Wowwww this is how the blob moves through the Canvas, towards its goal at the middle of the screen!
        public void Move(double targetX, double targetY)
        {
            // Basically calculating the direction we need to go from our xPos and yPos (hence the -Pos thingy)
            double directionX = targetX - xPos;
            double directionY = targetY - yPos;
            // And I thinkkkkk this will calculate the actually distance blob needs to go? idk...
            double distance = directionX * directionY;

            // Claude helped me write this, but apparently these formulas are giving me a NORMALIZED VECTOR (direction / distance will always = 1). 
            if (distance > 0)
            {
                xPos += (directionX / distance) * Speed;
                yPos += (directionY / distance) * Speed;
            }
        }
    }
}
