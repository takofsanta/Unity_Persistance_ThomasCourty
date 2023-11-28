using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    [SerializeField] private Button Play;
    [SerializeField] private GameObject Portal;
    public ObjectiveDatas[] Objectives;
    [SerializeField] QuestDatas _questData;
    [SerializeField] ScoreData _scoreData;


    public void PlayGame()
    {
        scoreData.InitScoreValue(0);
        SceneManager.LoadScene(1);

        
        //Reset toutes les valeurs persistantes au démarrage du jeu
        Objectives[0].ActualValue = 0;
        Objectives[1].ActualValue = 0;
        Objectives[2].ActualValue = 0;
        Objectives[0].IsFinished = false;
        Objectives[1].IsFinished = false;
        Objectives[2].IsFinished = false;
        _questData.IsFinished = false;
        _questData.IsStarted = false;
        _scoreData.ScoreValue = 0;
    }

    public void WalkPortal()
    {
        SceneManager.LoadScene(2);
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);

    }
}
