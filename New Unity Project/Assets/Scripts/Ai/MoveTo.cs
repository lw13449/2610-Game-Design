using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Transform goal;

    public void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}