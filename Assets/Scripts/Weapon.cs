using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon/Create new Weapon", order = 51)]
public class Weapon : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private int _damage;
    [SerializeField] private DamageType _damageType;

    public string Name => _name;
    public string Description => _description;
    public int Damage => _damage;
    public DamageType DamageType => _damageType;
}
