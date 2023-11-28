using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private LevelManager _levelManager;
    private void OnTriggerEnter(Collider other)
    {
        ICollectible iCollect = other.GetComponent<ICollectible>();
        if (iCollect != null)
        {
            iCollect.Collect();
        }

        ITalk talking = other.GetComponent<ITalk>();
        if (talking != null )
        {
            talking.Talk();
        }

        if (other.CompareTag("LevelChanger"))
        {
            _levelManager.WalkPortal();
        }
    }

}
