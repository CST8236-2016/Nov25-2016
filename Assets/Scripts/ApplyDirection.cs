using UnityEngine;
using System.Collections;

public class ApplyDirection : MonoBehaviour {

  // Direction we will be moving in.
  public Vector3 direction;

  // Whether or not we want to use 'discrete-styled' movement. 
  public bool isDiscrete = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if(Input.GetKeyDown(KeyCode.Space)) {
      // Only move forward if we're working in discrete mode.
      if(isDiscrete) {
        transform.localPosition += direction;
      }
      else {
        // Stores any information relevant to a collision.
        RaycastHit hit;

        // This call will only populate the above variable if it returns true.
        bool didHit = Physics.Raycast(
          transform.position, // where we start the ray from
          direction, // direction of the ray.
          out hit, // variable to store results of any collision
          direction.magnitude // length of the ray
          );

        if(didHit) {
          //transform.position = hit.point;
          transform.position += (hit.distance * direction.normalized);
        }
      }
    }
	}
}
