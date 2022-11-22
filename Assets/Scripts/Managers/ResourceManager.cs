using System.Collections.Generic;
using Resources;
using UnityEngine;
using UnityEngine.Events;

public enum ResourceType
{
    GOLD
}


public class ResourceManager : MonoBehaviour
{
    public UnityAction ONIncrease;
    
    [SerializeField] private List<ResourceSO> _allRes = new List<ResourceSO>();

    public void IncreaseResource(ResourceType type, int count)
    {   
        _allRes.Find(t => t.Type == type).IncreaseCount(count);
    }
}



