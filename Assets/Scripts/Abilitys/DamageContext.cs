using System;
using System.Collections.Generic;
using System.Linq;

public class DamageContext
{
    private List<Damage> _damages;
    private int _blockedDamage;

    public DamageContext(List<Damage> damages,int blockedDamage,BasePerson attaker,BasePerson defender,int turn)
    {
        _damages = damages;
        _blockedDamage = blockedDamage;
        Attacker = attaker;
        Defender = defender;
        Turn = turn;
    }

    public BasePerson Attacker { get; } // добавить метод Copy  и передавать копию 
    public BasePerson Defender { get; }
    public int Turn { get; }

    public DamageContext(List<Damage> damages, BasePerson attacker, BasePerson defender)
    {
        _damages = new List<Damage>(damages);
        Attacker = attacker;
        Defender = defender;
        _blockedDamage = 0;
    }

    public void RemoveDamages(Predicate<Damage> predicate)
    {
        _damages.RemoveAll(predicate);
    }

    public void ModifyDamage(Func<Damage,bool> predicate, int multiplier)
    {
        foreach (Damage damage in _damages.Where(predicate).ToList())
        {
            _damages.Remove(damage);
            AddDamage(new Damage(damage.Type, damage.Sourse, damage.Value * multiplier));
        }
    }

    public void AddDamage(Damage damage)
    {
        if (damage != null)
            _damages.Add(damage);
    }

    public void AddBlockedDamage(int damage)
    {
        if (damage > 0)
            _blockedDamage += damage;
    }
}