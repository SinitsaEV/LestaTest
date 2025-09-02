public class HiddenAttack : BaseAbility, IOnAttack
{
    private int _damage;

    public HiddenAttack(int damage, int priority, string name) : base(priority, name)
    {
        _damage = damage;
    }

    public void OnAttack(DamageContext damageContext)
    {
        if (damageContext.Attacker.Agility > damageContext.Defender.Agility)
            damageContext.AddDamage(new Damage(DamageType.Mage, DamageSourse.Ability, _damage));
    }
}
