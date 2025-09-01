using System.Collections.Generic;
using System.Linq;

public class DamageContext
{
    private readonly List<Damage> _damages;

    public IReadOnlyList<Damage> Damages => _damages.AsReadOnly();
    public BasePerson Attacker { get; }
    public BasePerson Defender { get; }

    public DamageContext(List<Damage> damages, BasePerson attacker, BasePerson defender)
    {
        _damages = new List<Damage>(damages);
        Attacker = attacker;
        Defender = defender;
    }

    public void RemoveDamagesOfType(DamageType type)
    {
        _damages.RemoveAll(d => d.Type == type);
    }

    public void ModifyDamage(Damage damage, int newValue)
    {
        if (_damages.Contains(damage))
        {
            //damage.Value = Mathf.Max(0, newValue);
        }
    }
}