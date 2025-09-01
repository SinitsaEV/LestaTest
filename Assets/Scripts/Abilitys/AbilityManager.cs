using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    private List<IOnAttack> _attackList;
    private List<IDefenseAbility> _defendList;

    public void UseDefendAbility(DamageContext damageContext)
    {
        foreach(IDefenseAbility defend in _defendList)
        {
            //defend.OnDefend(damages);
        }
    }

    public void UseAttackAbility(DamageContext damageContext)
    {

    }
}
