using RimWorld;

namespace LingGame;

public class CompTargetable_PawnHasDeathAcidifier : CompTargetable_SinglePawn
{
    public override TargetingParameters GetTargetingParameters()
    {
        return new TargetingParameters
        {
            canTargetPawns = true,
            canTargetBuildings = false
        };
    }
}