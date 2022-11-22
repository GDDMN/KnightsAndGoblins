using UnityEngine;

public class WeaponModel : ScriptableObject
{
    [SerializeField] private WeaponType _type;
    [SerializeField] private string _name;
    [SerializeField] private float _actionRadius;
    [SerializeField] private float _damage;
    
    public float ActionRadius => _actionRadius;
    public WeaponType Type => _type;
    public float Damage => _damage;
    public string Name => _name;
}
