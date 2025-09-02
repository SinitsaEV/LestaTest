public abstract class BasePerson 
{
    protected int _strength;  // сила
    protected int _agility;   // ловкость 
    protected int _stamina;   // Выносливость

    protected Health _health;
    protected Weapon _weapon;

    public int Strength => _strength;
    public int Agility => _agility;
    public int Stamina => _stamina;    
}

