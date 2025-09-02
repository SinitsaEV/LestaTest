public class Poison : BaseAbility, IOnAttack
{
    private int _startDamage;
    private int _turnWork;
    private int _currentDamage;
    private int _turnDamagePlus;

    public Poison(int priority, string name, int turn, int startDamage, int turnDamagePlus) : base(priority, name)
    {
        _startDamage = startDamage;
        _turnWork = turn;
        _turnDamagePlus = turnDamagePlus;
        _currentDamage = _startDamage;
    }

    public void OnAttack(DamageContext damageContext)
    {
        if (damageContext.Turn < _turnWork)
        {
            damageContext.AddDamage(new Damage(DamageType.Mage, DamageSourse.Ability, _currentDamage));
            _currentDamage += _turnDamagePlus;
        }
    }
}
