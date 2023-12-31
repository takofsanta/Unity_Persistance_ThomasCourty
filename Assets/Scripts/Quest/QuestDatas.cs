
using System;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ScoreData;

[CreateAssetMenu(menuName = "New Quest")]

public class QuestDatas : ScriptableObject
{
    public ObjectiveDatas[] Objectives;
    public bool IsStarted;
    public bool IsFinished;
    public delegate void QuestUpdate(int value);
    public static event QuestUpdate OnUpdate;


    public void CheckQuest() 
    {
        bool result = true;
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (!Objectives[i].IsFinished)
            {
                result = false;
                break;
            }
        }
        if (result)
        {
            if (IsStarted == true)
            {
                EndQuest();
            }

        }
    }
    public void StartQuest()
    {
        IsStarted = true;
        CheckQuest();
    }
    public void EndQuest()
    {
        IsFinished = true;
        Debug.Log("Bravo c'est gagn�");
        SceneManager.LoadScene(0);

    }

    public void CheckObjective(int NumObject)
    {
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (Objectives[NumObject].ActualValue >= Objectives[NumObject].MaxValue)
            {
                Objectives[NumObject].IsFinished = true;
                OnUpdate?.Invoke(1);
                CheckQuest();
            }
        }
    }

    public void UpdateObjective(Collectible collectible)
    {
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (Objectives[i].CollectibleType == collectible.GetCollectibleType())
            {
                Objectives[i].ActualValue += collectible.GetCollectibleValue();
                CheckObjective(i);

                break;
            }
        }

    }

    internal void UpdateObjective(LevelManager levelManager)
    {
        throw new NotImplementedException();
    }
}
