using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshPatrol : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;
    }
}
