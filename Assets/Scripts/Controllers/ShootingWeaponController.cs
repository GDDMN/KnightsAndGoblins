using System.Collections.Generic;
using UnityEngine;

public class ShootingWeaponController : WeaponController
{
    [SerializeField] private List<GameObject> _allEnemys = new List<GameObject>();
    [SerializeField] private SphereCollider _circleCollider;

    [SerializeField] private GameObject _target;
    [SerializeField] private float _time = 0.0f;
    [SerializeField] private ArrowController _arrow;
    
    private void OnDrawGizmos()
    {
        UnityEditor.Handles.color = Color.white;
        UnityEditor.Handles.DrawWireArc(transform.position, Vector3.up, Vector3.forward, 360, Model.ActionRadius);        
    }

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _circleCollider.radius = Model.ActionRadius;
    }

    private void Update()
    {
        WeaponIdleBeh();
    }

    public override void Attack()
    {
        Destroy(_target);
    }

    public override void WeaponIdleBeh()
    {
        _time += TIME_SPEED * Time.deltaTime;
        if (!TimeChecker())
        {
            Attack();
            return;
        }
        
        if (_allEnemys.Count == 0)
            return;

        FindTarget();
    }

    private void FindTarget()
    {
        float distance = Model.ActionRadius;
        foreach (var enemy in _allEnemys)
        {
            if (distance >= Vector3.Distance(transform.position, enemy.transform.position))
                return;

            distance = Vector3.Distance(transform.position, enemy.transform.position);
            _target = enemy;
        }
    }
    
    
    private bool TimeChecker()
    {
        if (CooldownTime > _time)
            return true;
        
        _time = 0.0f;
        return false;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Enemy")
            return;
        
        _allEnemys.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Enemy")
            return;

        _allEnemys.Remove(other.gameObject);
    }
}
