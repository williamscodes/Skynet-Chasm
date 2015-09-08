var road = parseInt(readline()); // the length of the road before the gap.
var gap = parseInt(readline()); // the length of the gap.
var platform = parseInt(readline()); // the length of the landing platform.
var jumped = false;

// game loop
while (true)
{
    var speed = parseInt(readline()); // the motorbike's speed.
    var coordX = parseInt(readline()); // the position on the road of the motorbike.

    // If speed is less than required to jump the gap and player loc is not in jump zone jump accel
    if ((speed < (gap + 1)) && coordX < (road - 1))
    {
        print('SPEED');
    }
    
    // If speed is greater than required and player loc is not in jump zone hold speed
    else if (speed == (gap + 1) && coordX < (road - 1))
    {
        print('WAIT');
    }
    
    // If player loc is in jump zone jump
    else if ((road - 1) == coordX)
    {
        print('JUMP');
    }
    
    // If speed is higher than necessary to jump
    else if (speed > (gap + 1))
    {
        print('SLOW');
    }
    
    // If player loc is greater than jump zone
    else if (coordX > (road -1))
    {
        print('SLOW');
    }
    
    // Else accel
    else
    {
        print('SPEED');
    }
}
