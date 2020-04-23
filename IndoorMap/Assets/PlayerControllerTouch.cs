using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControllerTouch : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1) 
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {   
                // If long press registered
                if (touch.deltaTime > 0.3f)
                {
                    //Store the ray that camera sees through the touch point
                    Ray ray = cam.ScreenPointToRay(touch.position);
                    RaycastHit hit;

                    // Getting the intersection between the ray and 
                    // our geometry into 'hit' variable
                    if (Physics.Raycast(ray, out hit)) 
                    {
                        // Set and go to the hit location
                        agent.SetDestination(hit.point);
                    }
                }
            }
        }
        
    }
}
