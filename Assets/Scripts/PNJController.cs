using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour, ITalk
{
    private DialogSystem _dialogSystem;
    [SerializeField] private int _startSentence;
    [SerializeField] private int _intermediateSentence;
    [SerializeField] private int _endSentence;
    [SerializeField] private QuestDatas _questDatas;


    private void Start()
    {
        _dialogSystem = GetComponent<DialogSystem>();
    }

    public void Talk()
    {
        if (_questDatas.IsStarted)
        {
            if (_questDatas.IsFinished)
            {
                _dialogSystem.StartTalking(_endSentence);

            }
            else
            {
                _dialogSystem.StartTalking(_intermediateSentence);

            }
        }
        else
        {
            _dialogSystem.StartTalking(_startSentence);
        }
    }
}
