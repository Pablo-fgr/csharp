using System;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
   
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainer) => ExpectedMinutesInOven() - remainer;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int MINUTES_PER_LAYER = 2;
        return layers * MINUTES_PER_LAYER;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutes) => PreparationTimeInMinutes(layers) + minutes;
}
