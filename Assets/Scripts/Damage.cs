public class Damage
{
    private DamageType _type;
    private DamageSourse _sourse;
    private int _value;

    public Damage(DamageType damageType, DamageSourse sourse, int value)
    {
        _type = damageType;
        _sourse = sourse;
        _value = value;
    }

    public DamageType Type => _type;
    public DamageSourse Sourse => _sourse;
    public int Value => _value;
}