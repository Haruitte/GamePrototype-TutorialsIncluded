using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PLayer>(out Player player))
        {
            Debug.Log("Checkpoint!");
        }
    }

}
