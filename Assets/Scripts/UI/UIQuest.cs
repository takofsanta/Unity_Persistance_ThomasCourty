
using UnityEngine;
using TMPro;
using static QuestDatas;


public class UIQuest : MonoBehaviour
{
    [SerializeField] GameObject _QuestPanel;
    [SerializeField] TMP_Text _Objective1;
    [SerializeField] TMP_Text _Objective2;
    [SerializeField] TMP_Text _Objective3;
    public ObjectiveDatas[] Objectives;



    public void ShowQuest(ObjectiveDatas[]objectives)
    {
        _QuestPanel.SetActive(true);
        _Objective1.text = objectives[0].Name;
        _Objective2.text = objectives[1].Name;
        _Objective3.text = objectives[2].Name;

    }

    private void OnEnable()
    {
        ScoreData.OnUpdate += MiseEnFormeQuest;
    }

    private void OnDisable()
    {
        ScoreData.OnUpdate -= MiseEnFormeQuest;
    }
    public void MiseEnFormeQuest(int numberValue)
    {
        if (Objectives[numberValue].IsFinished == true)
        {
            _Objective1.text = "Finished";
            _Objective2.text = "Finished";
            _Objective3.text = "Finished";
        }
    }
}
