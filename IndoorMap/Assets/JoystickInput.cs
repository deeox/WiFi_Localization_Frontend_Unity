using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    protected Joystick joystick;
    public float threshold;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(-joystick.Vertical * threshold + Input.GetAxis("Vertical"),
                                        rigidbody.velocity.y,
                                        joystick.Horizontal * threshold + Input.GetAxis("Horizontal"));
    }
}
