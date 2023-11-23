
using UnityEngine;

[CreateAssetMenu(menuName = "New Objective")]


public class ObjectiveDatas : ScriptableObject
{
    public string Name;
    public int NumberValue;
    public int MaxValue;
    public int ActualValue;
    public string CollectibleType;
    public bool IsFinished;
}