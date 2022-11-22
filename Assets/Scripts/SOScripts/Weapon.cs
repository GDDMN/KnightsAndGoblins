using UnityEngine;

public class Weapon : ScriptableObject
{
    [SerializeField] private WeaponType _type;
    [SerializeField] private float _actionRadius;

    
    public float ActionRadius => _actionRadius;
    public WeaponType Type => _type;
}
