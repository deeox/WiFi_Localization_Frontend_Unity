using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownController : MonoBehaviour {

    public UnityEngine.AI.NavMeshAgent agent;

    public void HandleInputData(int val){
        Vector3 GF_1 = new Vector3(-11.82f, 0.21f, 7.65f);
        Vector3 GF_2 = new Vector3(-2.91f, 0.21f, 7.65f);
        Vector3 GF_3 = new Vector3(5.96f, 0.21f, 7.65f);
        Vector3 GF_4 = new Vector3(-11.82f, 0.21f, -10.02f);
        Vector3 GF_5 = new Vector3(-2.91f, 0.21f, -10.02f);
        Vector3 GF_6 = new Vector3(-11.82f, 0.21f, -10.02f);
        Vector3 FF_1 = new Vector3(-11.82f, 6.35f, 7.65f);
        Vector3 FF_2 = new Vector3(-2.91f, 6.35f, 7.65f);
        Vector3 FF_3 = new Vector3(5.96f, 6.35f, 7.65f);
        Vector3 FF_4 = new Vector3(-11.82f, 6.35f, -10.02f);
        Vector3 FF_5 = new Vector3(-2.91f, 6.35f, -10.02f);
        Vector3 FF_6 = new Vector3(-11.82f, 6.35f, -10.02f);
        switch (val)
        {
            case 0: agent.SetDestination(GF_1); break;
            case 1: agent.SetDestination(GF_2); break;
            case 2: agent.SetDestination(GF_3); break;
            case 3: agent.SetDestination(GF_4); break;
            case 4: agent.SetDestination(GF_5); break;
            case 5: agent.SetDestination(GF_6); break;
            case 6: agent.SetDestination(FF_1); break;
            case 7: agent.SetDestination(FF_2); break;
            case 8: agent.SetDestination(FF_3); break;
            case 9: agent.SetDestination(FF_4); break;
            case 10: agent.SetDestination(FF_5); break;
            case 11: agent.SetDestination(FF_6); break;
            default: break;
        }
    }
}

