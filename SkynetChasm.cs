using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
            
            // If Speed is less than required and player loc is not within jump zone accel
            if ((speed < (gap + 1)) && (coordX < (road - 1)))
            {
                Console.WriteLine("SPEED");
            }
            // If speed is required speed and player loc is not within jump zone hold speed
            else if ((speed == (gap + 1)) && (coordX < (road - 1)))
            {
                Console.WriteLine("WAIT");
            }
            // If player loc is within jump zone jump
            else if (coordX == (road - 1))
            {
                Console.WriteLine("JUMP");
            }
            // If player speed is greater than required speed  or player loc is not in jump zone decel
            else if ((speed > (gap + 1)) || (coordX > (road - 1)))
            {
                Console.WriteLine("SLOW");
            }
            // Else accel
            else
            {
                Console.WriteLine("SPEED");
            }
        }
    }
}
