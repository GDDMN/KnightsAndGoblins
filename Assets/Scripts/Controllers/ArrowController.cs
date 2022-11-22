using UnityEngine;
using UnityEngine.AI;

public class ArrowController : MonoBehaviour
{
    private GameObject _target;
    
    [SerializeField] private float _speed;
    [SerializeField] private NavMeshAgent _arrowAgent;
    
    public void Initialize(GameObject target)
    {
        _arrowAgent.speed = _speed;
        _target = target;
    }

    private void Update()
    {
        _arrowAgent.SetDestination(_target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Enemy")
            return;
        
        Destroy(other);
        Destroy(gameObject);
    }
}
