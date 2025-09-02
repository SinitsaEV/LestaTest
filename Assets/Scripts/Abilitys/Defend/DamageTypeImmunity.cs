public class DamageTypeImmunity : BaseAbility, IDefenseAbility
{
    private DamageType _damageTypeImmunity;

    public DamageTypeImmunity(int priority, DamageType damageType, string name) : base(priority, name)
    {
        _damageTypeImmunity = damageType;
    }

    public void OnDefend(DamageContext damageContext)
    {
        damageContext.RemoveDamages(damage => damage.Type == _damageTypeImmunity);
    }
}
