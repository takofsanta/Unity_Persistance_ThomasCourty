using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelCheck : MonoBehaviour
{
    [SerializeField] ScoreData _scoreData;
    [SerializeField] QuestDatas _questData;
    [SerializeField] DialogSystem _dialogSystem;
    [SerializeField] UIQuest _UIQuest;

    void Start()
    {
        _scoreData.UpdateScoreValue(0);
        if (_questData.IsStarted == true)
        {
            _dialogSystem.QuestValid();
            _UIQuest.MiseEnFormeQuest(0);
        }
    }


}
