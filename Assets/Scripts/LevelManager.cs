using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    // Start is called before the first frame update
    void Start()
    {
        scoreData.InitScoreValue(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
