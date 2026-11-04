using System.Linq;
using Verse;

namespace LingGame;

public static class LingHealthUnity
{
    public static BodyPartRecord GetBodyPart(Pawn pawn, string bodypartdef)
    {
        return pawn.health.hediffSet.GetNotMissingParts()
            .FirstOrDefault(part => part.def.defName.Contains(bodypartdef));
    }
}