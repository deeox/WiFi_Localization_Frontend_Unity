using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshLine : MonoBehaviour
{
    public static Vector3[] path = new Vector3[0];
    private NavMeshAgent agent;
    private LineRenderer lr;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {   
        //Get the path points from the NavMeshAgent
        // lr is of LineRenderer class
        path = agent.path.corners;
        if (path != null && path.Length > 1)
        {
            lr.positionCount = path.Length;
            for (int i = 0; i < path.Length; i++)
            {
                // Set points from NavMeshAgent path
                lr.SetPosition(i, path[i]);
            }
        }
    }
}
