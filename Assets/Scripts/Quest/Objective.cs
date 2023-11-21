
using UnityEngine;

[CreateAssetMenu(menuName = "New Objective")]


public class ObjectiveDatas : ScriptableObject
{
    public string Name;
    public int MaxValue;
    public int StartValue;
    public int ActualValue;
    public string CollectibleType;
    public bool IsFinished;
}