public class Shield : BaseAbility, IDefenseAbility
{
    private int _blokedDamage;

    public void OnDefend(DamageContext damageContext)
    {
        if(damageContext.Attacker.Strength < damageContext.Defender.Strength)
            damageContext.AddBlockedDamage(_blokedDamage);
    }

    public Shield(int priority, int blokedDamage, string name) : base(priority, name)
    {
        _blokedDamage = blokedDamage;
    }
}
