using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour, ICollectible
{
    [SerializeField] int _value;
    [SerializeField] ScoreData _scoreData;
    [SerializeField] string _collectibleType;
    [SerializeField] QuestDatas _questData;

    public void Collect()
    {
        _scoreData.UpdateScoreValue(_value);
        _questData.UpdateObjective(this);
        Destroy(gameObject);
    }

    public string GetCollectibleType()
    {
        return _collectibleType;
    }

    public int GetCollectibleValue() 
    {
        return _value;
    }

}
