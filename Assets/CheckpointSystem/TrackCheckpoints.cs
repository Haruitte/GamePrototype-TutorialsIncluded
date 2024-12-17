using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
  
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");
        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackCheckpoints(this);
        }
    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle)
    {

    }

}
