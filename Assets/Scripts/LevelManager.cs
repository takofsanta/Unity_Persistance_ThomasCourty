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



    public void PlayGame()
    {
        scoreData.InitScoreValue(0);
        SceneManager.LoadScene(1);
    }

    public void WalkPortal()
    {
        SceneManager.LoadScene(2);

    }
}
