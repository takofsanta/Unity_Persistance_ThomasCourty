using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ICollectible>() != null)
        {
            other.GetComponent<ICollectible>().Collect();
        }
    }
}
