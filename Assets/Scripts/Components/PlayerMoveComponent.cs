using System;
using UnityEngine;

[Serializable]
public struct PlayerMoveComponent
{
    public float speed;
    public Rigidbody rigidbody;
    public Transform transform;
}