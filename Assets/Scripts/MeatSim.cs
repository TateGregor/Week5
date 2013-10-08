using UnityEngine;
using System.Collections;

public class MeatSim : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit rayHit = new RaycastHit();

		if (Physics.Raycast(ray, out rayHit, 200f)){
			int n = Random.Range(0,10);
			if ( n < 5 ){
				transform.Rotate (new Vector3(0, 90, 0));
			}else{
				transform.Rotate (new Vector3(0, -90, 0));
			}
		}
	}

	void FixedUpdate(){
		rigidbody.AddRelativeForce(Vector3.forward * 200);
	}

}
