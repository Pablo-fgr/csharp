using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = [0,2,5,3,7,8,4];
        return lastWeek;
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        int longitud = birdsPerDay.Length;
        birdsPerDay[longitud-1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(x => x == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }
        return count;   
    }

    public int BusyDays()
    {
        return birdsPerDay.Where(x => x >= 5).Count();
    }
}
