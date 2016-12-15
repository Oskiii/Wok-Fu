using UnityEngine;
using System.Collections;

public class SetHandPosToMouse : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;
	public GameObject shoulder;
	private float maxDistance;
	private Rigidbody2D rb;
	
	void Start (){

		maxDistance = (gameObject.transform.position - shoulder.transform.position).magnitude;
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update () {
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		print (maxDistance);
	
		rb.velocity = GetDirection ();
		//rb.AddForce (GetDirection () * 100);
		//if ((mousePosition - (shoulder.transform.position)).magnitude < maxDistance) {
			
			//transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed);
		//}
	}

	Vector2 GetDirection(){
		return new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")).normalized;
	}
}
