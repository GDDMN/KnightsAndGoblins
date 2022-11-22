using UnityEngine;

[CreateAssetMenu(fileName = "Resource", menuName = "ScriptableObjects/Resource", order = 1)] 
public class ResourceModel : ScriptableObject 
{
    [SerializeField] private string _name;
    [SerializeField] private int _count; 
    [SerializeField] private Sprite _icon; 
    [SerializeField] private ResourceType _type;
    
    public void IncreaseCount(int count) 
    { 
        _count += count;
    }
    
    public bool DecreaseCount(int count) 
    { 
        if (_count < count) 
            return false;
    
        _count -= count; 
        return true;
    }
    
    
    public string Name => _name;
    public int Count => _count; 
    public Sprite Icon => _icon; 
    public ResourceType Type => _type;
}