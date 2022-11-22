using UnityEngine;

public abstract class WeaponController : MonoBehaviour
{
    [SerializeField] protected WeaponModel _model;
    [SerializeField] protected float _cooldownTime;

    public WeaponModel Model => _model;

    public float CooldownTime => _cooldownTime;
    
    public abstract void Attack();

    public abstract void WeaponIdleBeh();
}