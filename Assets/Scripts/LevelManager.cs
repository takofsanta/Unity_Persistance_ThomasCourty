using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    // Start is called before the first frame update
    private void Start()
    {
        scoreData.InitScoreValue(0);
    }

}
