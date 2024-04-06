using System.Collections.Generic;
using RimWorld;
using Verse;

namespace LingGame;

public class CompProerties_UpGradeLingXCGShip : CompUseEffect
{
    public override AcceptanceReport CanBeUsedBy(Pawn p)
    {
        if (NeedGradeHediffs(p).Count == 0)
        {
            return "NoLingXCGShipNeedUpGrade".Translate(p.Name.ToStringShort);
        }

        return true;
    }

    public override void DoEffect(Pawn usedBy)
    {
        string title = "YouFeelEnergySurgingInsideYou".Translate();
        string text = "SelectAChipUpgrade".Translate();
        var diaNode = new DiaNode(text);
        foreach (var item in NeedGradeHediffs(usedBy))
        {
            var diaOption = new DiaOption(item.def.label)
            {
                action = delegate
                {
                    parent.Destroy();
                    item.Severity += 0.2f;
                    Messages.Message("MyChipToUpgrade".Translate(usedBy.Name.ToStringShort, item.def.label),
                        usedBy, MessageTypeDefOf.PositiveEvent);
                },
                resolveTree = true
            };
            diaNode.options.Add(diaOption);
        }

        Find.WindowStack.Add(new Dialog_NodeTree(diaNode, true, true, title));
    }

    private List<Hediff> NeedGradeHediffs(Pawn pawn)
    {
        var list = new List<Hediff>();
        foreach (var hediff in pawn.health.hediffSet.hediffs)
        {
            if (hediff.def.defName.Contains("LingXCG") && hediff.Severity <= 0.79)
            {
                list.Add(hediff);
            }
        }

        return list;
    }
}