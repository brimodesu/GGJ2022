using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
public class NPC : MonoBehaviour
{
    public NavMeshAgent agent;
    [Range(0, 100)] public float speed;
    [Range(0, 100)] public float walkRadius;

    private Animator animator;
    private bool isScared = false;

    public void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = speed;
            agent.SetDestination(RandomNavMeshLocation());
            animator.SetBool("Walking", true);
        }
    }

    private void Update()
    {
        if (agent != null && agent.remainingDistance <= agent.stoppingDistance && !isScared)
        {
            agent.SetDestination(RandomNavMeshLocation());
        }
    }

    public Vector3 RandomNavMeshLocation()
    {
        Vector3 finalPosition = Vector3.zero;
        Vector3 randomPosition = Random.insideUnitSphere * walkRadius;
        randomPosition += transform.position;
        if (NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, walkRadius, 1))
        {
            finalPosition = hit.position;
            
        }

        return finalPosition;
    }

    public void setScared()
    {
        isScared = true;
        animator.SetBool("Walking", false);
        animator.SetBool("Scared", isScared);
    }
}