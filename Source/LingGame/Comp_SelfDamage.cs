using RimWorld;
using Verse;

namespace LingGame;

public class Comp_SelfDamage : ThingComp
{
    public override void CompTick()
    {
        if (parent.IsHashIntervalTick(5000))
        {
            parent.TakeDamage(new DamageInfo(DamageDefOf.Cut, 1f, 2f));
        }
    }
}