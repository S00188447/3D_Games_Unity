using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveDirectlyTo : NavMeshMover
{
    public string tagToTrack = "Player";
    GameObject trackedPlayer;

    void Start()
    {
        trackedPlayer = GameObject.FindGameObjectWithTag(tagToTrack);

        base.start();
        
    }


    void Update()
    {
        if(trackedPlayer != null)
        {
            MoveTo(trackedPlayer)
        }
        
    }
}
