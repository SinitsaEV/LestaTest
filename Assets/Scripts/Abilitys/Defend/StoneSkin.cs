public class StoneSkin : BaseAbility, IDefenseAbility
{
    public StoneSkin(int priority, string name) : base(priority, name)
    {
    }

    public void OnDefend(DamageContext damageContext)
    {
        damageContext.AddBlockedDamage(damageContext.Defender.Stamina);
    }
}
