using UnityEngine;
using System.Collections;

public class PointClickCity : MonoBehaviour {

	Vector3 spot;

	// Use this for initialization
	void Start () {
		spot = transform.position;
	}

	// Update is called once per frame
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit rayHit = new RaycastHit();

		if (Input.GetMouseButtonDown(0)){
			if ( Physics.Raycast(ray, out rayHit)){
				spot = rayHit.point;
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			transform.Rotate ( 0f, -45f ,0f );
				}
			}
		}

	}

	void FixedUpdate (){

		Vector3 direction = Vector3.Normalize( spot - transform.position );

		if (Vector3.Distance(spot, transform.position) > 35){
        	rigidbody.AddForce( direction * 50 );
		}
	}
} 