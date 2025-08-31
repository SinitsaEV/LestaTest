using System.Collections.Generic;
using UnityEngine;

public class Profession 
{
    [SerializeField] private string _name;
    [SerializeField] private int _healthForLevel;
    [SerializeField] private Weapon _startWeapon;
    [SerializeField] private Dictionary<int, BaseAbility> _abilitiesForLevels;

    public Profession(string name,int healthForLEvel,Weapon startWeapon, Dictionary<int, BaseAbility> abilitiesForLevels)
    {
        _name = name;
        _healthForLevel = healthForLEvel;
        _startWeapon = startWeapon;
        _abilitiesForLevels = abilitiesForLevels;
    }

    public string Name => _name;
    public int HealthForLevel => _healthForLevel;
    public Weapon StartWeapon => _startWeapon;

    public BaseAbility GetAbilityForLevel(int level)
    {
        _abilitiesForLevels.TryGetValue(level, out BaseAbility ability);

        return ability;
    }
}
