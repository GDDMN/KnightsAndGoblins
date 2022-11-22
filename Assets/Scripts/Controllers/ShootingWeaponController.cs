using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShootingWeaponController : WeaponController
{
    [SerializeField] private List<EnemyComponent> _allEnemys = new List<EnemyComponent>();
    [SerializeField] private LineRenderer _lineRenderer;
    
    private void OnDrawGizmos()
    {
        UnityEditor.Handles.color = Color.white;
        UnityEditor.Handles.DrawWireArc(transform.position, Vector3.up, Vector3.forward, 360, Model.ActionRadius);        
    }

    public override void Attack()
    {
        
    }

    public override void WeaponIdleBeh()
    {
        
    }
}
