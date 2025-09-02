public class RushToAction : BaseAbility, IOnAttack
{
    private int _damageMultiplier;
    private int _workTurn;
    private DamageSourse _damageSourse;

    public RushToAction(int priority, string name, int turn, int damageMultiplier, DamageSourse damageSourse) : base(priority, name)
    {
        _damageMultiplier = damageMultiplier;
        _workTurn = turn;
        _damageSourse = damageSourse;
    }

    public void OnAttack(DamageContext damageContext)
    {
        if (damageContext.Turn == _workTurn)
            damageContext.ModifyDamage(damage => damage.Sourse == _damageSourse, _damageMultiplier);
    }
}
