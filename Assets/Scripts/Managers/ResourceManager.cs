using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResourceManager : MonoBehaviour
{
    public UnityAction ONIncrease;
    
    [SerializeField] private List<ResourceModel> _allRes = new List<ResourceModel>();

    public void IncreaseResource(ResourceType type, int count)
    {   
        _allRes.Find(t => t.Type == type).IncreaseCount(count);
    }
}



