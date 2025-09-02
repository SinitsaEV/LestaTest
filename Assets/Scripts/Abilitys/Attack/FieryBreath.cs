public class FieryBreath : BaseAbility, IOnAttack
{
    private int _workTurn;
    private int _damage;

    public FieryBreath(int priority, string name,int turn,int damage) : base(priority,name)
    {
        _workTurn = turn;
        _damage = damage;
    }

    public void OnAttack(DamageContext damageContext)
    {
        if (damageContext.Turn % _workTurn == 0)
        {
            damageContext.AddDamage(new Damage(DamageType.Mage, DamageSourse.Ability, _damage));
        }
    }
}
