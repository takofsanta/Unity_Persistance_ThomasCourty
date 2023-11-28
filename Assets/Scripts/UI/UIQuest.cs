
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
        MiseEnFormeQuest(0);

    }

    private void OnEnable()
    {
        QuestDatas.OnUpdate += MiseEnFormeQuest;
        MiseEnFormeQuest(1);
    }

    private void OnDisable()
    {
        QuestDatas.OnUpdate -= MiseEnFormeQuest;
    }
    public void MiseEnFormeQuest(int numberValue)
    {
        
        if (Objectives[0].IsFinished == true)
        {
            _Objective1.text = "Terminé";
        }

        if (Objectives[1].IsFinished == true)
        {
            _Objective2.text = "Terminé";

        }

        if (Objectives[2].IsFinished == true)
        {
            _Objective3.text = "Terminé";

        }

    }
}
