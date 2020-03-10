using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMover : MonoBehaviour
{
    public GameObject PlayerController;
    NavMeshAgent agent;

    void Start()
    {
        PlayerController.GetComponent<PlayerMovementRayCast>().RayCastReady += PlayerNavMover_RayCastReady;
        agent = GetComponent<NavMeshAgent>();
    }

    private void PlayerNavMover_RayCastReady(RaycastHit selectionData)
    {
        agent.destination = selectionData.point;
    }

}
