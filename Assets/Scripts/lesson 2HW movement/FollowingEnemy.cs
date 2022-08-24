using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class FollowingEnemy : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] Transform player;
    [SerializeField] Transform[] PatrolPoints;
    private int i;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(PatrolPoints[0].position);
    }

    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            i = (i+1) % PatrolPoints.Length;
            agent.SetDestination(PatrolPoints[i].position);
        }
    }
}
