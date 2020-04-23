using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput1 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
            transform.Translate (-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);

            transform.position = new Vector3 (
                Mathf.Clamp (transform.position.x, -35.0f, 25.0f),
                Mathf.Clamp (transform.position.y, 1.0f, 20.0f),
                Mathf.Clamp (transform.position.z, -9.0f, 15.0f)
            );
        }

        if (Input.touchCount == 2) {

            Touch touchZero = Input.GetTouch (0);
            Touch touchOne = Input.GetTouch (1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;


            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagDiff = prevTouchDeltaMag - touchDeltaMag;

            Camera.main.fieldOfView += deltaMagDiff * 0.1f;

            Camera.main.fieldOfView = Mathf.Clamp (Camera.main.fieldOfView, 15.0f, 70.0f);
        }
    }
}
