using UnityEngine;
using System.Collections;

public class SetHandPosToMouse : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;
	public GameObject shoulder;
	private float maxDistance;
	
	void Start (){

		maxDistance = (gameObject.transform.position - shoulder.transform.position).magnitude;
	}
	void Update () {
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		print (mousePosition.magnitude);
	
		if ((mousePosition - (shoulder.transform.position)).magnitude < maxDistance) {
			transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed);
		}
	}
}
