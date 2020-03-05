using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public delegate void ReachDestinationDelegate();

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshMover : MonoBehaviour
{

    protected NavMeshAgent agent;
    public event ReachDestinationDelegate ReachedDestination;
    public float RangeThreshold = 0.1f;

    public virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();    
    }

    public virtual void MoveTo(Vector3 position)
    {
        agent.SetDestination(position);
    }

    public virtual void MoveTo(GameObject position)
    {
        agent.SetDestination(gameObject.transform.position);
    }

    public virtual void Stop()
    {
        agent.isStopped = true;
    }

    public virtual void Resume()
    {
        agent.isStopped = false;
    }


    public void HasReachedDestination()
    {
        if(Vector3.Distance(transform.position, agent.destination) <= RangeThreshold)
        {
            //reached the destination
            if (ReachedDestination != null)
                ReachedDestination();
        }

    }


    public void Update()
    {
        if(agent.pathStatus == NavMeshPathStatus.PathComplete ||
                agent.pathStatus == NavMeshPathStatus.PathPartial)
        HasReachedDestination();
    }


}
