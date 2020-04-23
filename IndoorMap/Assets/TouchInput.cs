using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    public float speed;
	public GameObject target;
    const float pinchTurnRatio = Mathf.PI / 2;
	const float minTurnAngle = 0.1f;
 
	const float pinchRatio = 1;
	const float minPinchDistance = 0.5f;
 
	const float panRatio = 1;
	const float minPanDistance = 0;
 
	/// <summary>
	///   The delta of the angle between two touch points
	/// </summary>
	static public float turnAngleDelta;
	/// <summary>
	///   The angle between two touch points
	/// </summary>
	static public float turnAngle;
 
	/// <summary>
	///   The delta of the distance between two touch points that were distancing from each other
	/// </summary>
	static public float pinchDistanceDelta;
	/// <summary>
	///   The distance between two touch points that were distancing from each other
	/// </summary>
	static public float pinchDistance;
	private Vector3 point;

	void Start() 
	{
		point = target.transform.position;
		//transform.LookAt(point);
	}

    void Update()
    {
        float spd = speed;
		point = target.transform.position;
		//transform.LookAt(point);
        if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
            transform.Translate (-touchDeltaPosition.x * spd, -touchDeltaPosition.y * spd, 0);

            // transform.position = new Vector3 (
            //     Mathf.Clamp (transform.position.x, -35.0f, 25.0f),
            //     Mathf.Clamp (transform.position.y, 1.0f, 20.0f),
            //     Mathf.Clamp (transform.position.z, -9.0f, 15.0f)
            // );
        }

        if (Input.touchCount == 2) {

            float pinchAmount = 0;
            Quaternion desiredRotation = transform.rotation;

            TouchInput.Calculate();

            if (Mathf.Abs(TouchInput.pinchDistanceDelta) > 0)
            { // zoom
                pinchAmount = TouchInput.pinchDistanceDelta;
                Camera.main.fieldOfView -= pinchAmount * 0.1f;
            }

            if (Mathf.Abs(TouchInput.turnAngleDelta) > 0)
            { // rotate
                // Vector3 rotationDeg = Vector3.zero;
                // rotationDeg.x = -TouchInput.turnAngleDelta;
                // desiredRotation *= Quaternion.Euler(rotationDeg);

                transform.RotateAround(point, target.transform.up, TouchInput.turnAngleDelta);
            }


            // not so sure those will work:
            //transform.rotation = desiredRotation;
            //transform.position += Vector3.forward * pinchAmount;
        }
    }

    static public void Calculate () {
		pinchDistance = pinchDistanceDelta = 0;
		turnAngle = turnAngleDelta = 0;
 
		// if two fingers are touching the screen at the same time ...
		if (Input.touchCount == 2) {
			Touch touch1 = Input.touches[0];
			Touch touch2 = Input.touches[1];
 
			// ... if at least one of them moved ...
			if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved) {
				// ... check the delta distance between them ...
				pinchDistance = Vector2.Distance(touch1.position, touch2.position);
				float prevDistance = Vector2.Distance(touch1.position - touch1.deltaPosition,
				                                      touch2.position - touch2.deltaPosition);
				pinchDistanceDelta = pinchDistance - prevDistance;
 
				// ... if it's greater than a minimum threshold, it's a pinch!
				if (Mathf.Abs(pinchDistanceDelta) > minPinchDistance) {
					pinchDistanceDelta *= pinchRatio;
				} else {
					pinchDistance = pinchDistanceDelta = 0;
				}
 
				// ... or check the delta angle between them ...
				turnAngle = Angle(touch1.position, touch2.position);
				float prevTurn = Angle(touch1.position - touch1.deltaPosition,
				                       touch2.position - touch2.deltaPosition);
				turnAngleDelta = Mathf.DeltaAngle(prevTurn, turnAngle);
 
				// ... if it's greater than a minimum threshold, it's a turn!
				if (Mathf.Abs(turnAngleDelta) > minTurnAngle) {
					turnAngleDelta *= pinchTurnRatio;
				} else {
					turnAngle = turnAngleDelta = 0;
				}
			}
		}
	}
 
	static private float Angle (Vector2 pos1, Vector2 pos2) {
		Vector2 from = pos2 - pos1;
		Vector2 to = new Vector2(1, 0);
 
		float result = Vector2.Angle( from, to );
		Vector3 cross = Vector3.Cross( from, to );
 
		if (cross.z > 0) {
			result = 360f - result;
		}
 
		return result;
	}
}
