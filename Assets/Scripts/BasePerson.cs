public abstract class BasePerson 
{
    protected int _strength;  // сила
    protected int _agility;   // ловкость 
    protected int _stamina;   // Выносливость

    protected Health _health;
    protected Weapon _weapon;


    DamageContext _damageContext;
    private void TAst()
    {
        foreach(Damage damage in _damageContext.Damages)
        {
            if(damage.Type == DamageType.Slashing)
            {
                _damageContext.ModifyDamage(damage, damage.Value * 2);
            }
        }
    }
}

