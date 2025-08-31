using System.Collections.Generic;

public abstract class BasePerson 
{
    private int _strength;  // сила
    private int _agility;   // ловкость 
    private int _stamina;   // Выносливость
    private float _health;

    private List<BaseAbility> _abilities;
}
