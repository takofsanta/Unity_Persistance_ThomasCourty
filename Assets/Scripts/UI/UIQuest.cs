
using UnityEngine;
using TMPro;


public class UIQuest : MonoBehaviour
{
    [SerializeField] GameObject _QuestPanel;
    [SerializeField] TMP_Text _Objective1;
    [SerializeField] TMP_Text _Objective2;
    [SerializeField] TMP_Text _Objective3;


    public void ShowQuest(ObjectiveDatas[]objectives)
    {
        _QuestPanel.SetActive(true);
        _Objective1.text = objectives[0].Name;
        _Objective2.text = objectives[1].Name;
        _Objective3.text = objectives[2].Name;

    }

}
