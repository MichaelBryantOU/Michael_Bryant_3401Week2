using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RedGuy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;
    public float MoveSpeed = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.position);
        agent.speed = MoveSpeed;
    }
}
