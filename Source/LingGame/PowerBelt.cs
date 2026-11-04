using RimWorld;

namespace LingGame;

public class PowerBelt : Apparel
{
    private float Power = 100f;

    private int ReNeedTime;

    private float PowerReS => this.GetStatValue(StatDefOf.EnergyShieldRechargeRate);

    private float PowerMas => this.GetStatValue(StatDefOf.EnergyShieldEnergyMax);

    public float ReMeedTimemas => this.GetStatValue(StatDef.Named("SmokepopBeltRadius"));

    private static bool CanReP => true;

    public void UsePower(float oe)
    {
        Power -= oe;
    }

    public void UsePower(int BaiFenBi)
    {
        Power -= PowerMas / (BaiFenBi / 100f);
    }

    public void UsePower()
    {
        Power = 0f;
    }

    public override void Tick()
    {
        base.Tick();
        if (ReNeedTime > 0)
        {
            ReNeedTime--;
            return;
        }

        if (Power <= 0f)
        {
            Power = 0f;
        }

        Power += PowerReS;
        if (Power >= PowerMas)
        {
            Power = PowerMas;
        }
    }
}