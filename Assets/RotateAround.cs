using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

  public float rotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    // point around which we rotate (world coordinates)
    // axis is the vector we rotate around.
    transform.RotateAround(transform.parent.position, Vector3.up, rotationSpeed * Time.deltaTime);

    // Rotate around an axis; specify the tilt of the axis, and the amount to rotate/frame.
    transform.Rotate(new Vector3(10, 20, 5), rotationSpeed * Time.deltaTime);

    /*foreach(Transform child in transform.parent) {
      Debug.Log("Where my child's at? " + child);
    }*/
	}
}
