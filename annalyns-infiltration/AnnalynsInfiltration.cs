using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake && !archerIsAwake) return true;
        else return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (knightIsAwake is true && archerIsAwake is true && petDogIsPresent is true) return false;
        if (knightIsAwake && petDogIsPresent) return true;
        if (knightIsAwake) return false;
        if (archerIsAwake) return false;
        if (prisonerIsAwake && petDogIsPresent) return true;
        if (prisonerIsAwake && !petDogIsPresent) return true;
        if (!archerIsAwake && petDogIsPresent) return true;
        if ((!knightIsAwake || !archerIsAwake || prisonerIsAwake) && petDogIsPresent)return true;
        
        return false;
    }
}
