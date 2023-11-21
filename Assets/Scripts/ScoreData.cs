using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "New Score")]
public class ScoreData : ScriptableObject

{
    public int ScoreValue;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    public void UpdateScoreValue(int value)
    {
        ScoreValue = Mathf.Clamp(ScoreValue + value, 0, 999);
        UpdateScoreUI();

    }

    public void InitScoreValue(int initValue)
    {
        UpdateScoreValue(initValue);
    }

    public void UpdateScoreUI()
    {
        OnUpdate?.Invoke(ScoreValue);
    }

}
