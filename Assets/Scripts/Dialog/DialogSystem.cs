using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private DialogDatas _DialogDatas;
    [SerializeField] private UIDialogLong _UIDialog;
    [SerializeField] private UIDialogAnswer _UIDialogAnswer;
    private int actualSentence;

    public void StartTalking(int DialogSentenceNumber)
    {
        actualSentence = DialogSentenceNumber;
        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[actualSentence].LongSentences);
        int[] answerNumbers = new int[2];
        answerNumbers[0] = _DialogDatas.Sentences[actualSentence].Answer1;
        answerNumbers[1] = _DialogDatas.Sentences[actualSentence].Answer2;
        string[] answers = new string[2];
        for (int i = 0; i < answers.Length; i++)
        {
            if (actualSentence == 7) 
            {
                _UIDialog.HideDialog();

            }
            if (answerNumbers[i] != -1)
            {
                answers[i] = _DialogDatas.Sentences[answerNumbers[i]].ShortSentences;

            }
            else
            {
                answers[i] = "";

            }
        }

        _UIDialogAnswer.ShowAnswers(answers);
    }

    public void SelectAnswer(int answerNumber)
    {
        if (answerNumber == 0)
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].Answer1);

        }
        else
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].Answer2);

        }
    }

}
