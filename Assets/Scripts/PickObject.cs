using UnityEngine;
using System.Collections;

// Tells Unity that whatever object has this script must ALSO have a camera.
[RequireComponent(typeof(Camera))]
public class PickObject : MonoBehaviour {
  // Store the camera on this object.
  Camera _currentCamera;

  // Store the material we want to change the hit object to.
  public Material materialToChangeTo;

  Ray _lastRayCast;
  float _raycastDistance = 1.0f;
	
  // Use this for initialization
	void Start () {
    // Get the camera component on the current GameObject.
    _currentCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
    Debug.DrawRay(_lastRayCast.origin, _lastRayCast.direction * _raycastDistance, Color.red);

	  // Select an object based on mouse click.
    // button 0 is the left mouse button.
    if(Input.GetMouseButtonDown(0) == true) {
      // Create a ray that represents the 3D equivalent of our 2D position in the window frame.
      Ray clickRay = _currentCamera.ScreenPointToRay(Input.mousePosition);
      _lastRayCast = clickRay;

      // This stores what we have hit with our raycast.
      RaycastHit hit; 

      // Cast the click ray into the world and see what is hit.
      bool didHit = Physics.Raycast(clickRay, out hit);
      if(didHit) {
        Debug.Log("Hey! We hit something!");

        // Grab the GameObject we hit, and store it for later.
        GameObject objectWeHit = hit.transform.gameObject;

        _raycastDistance = hit.distance;

        if(materialToChangeTo != null) {
          // Grabs the MeshRenderer from the objectWeHit so that we can change its material.
          MeshRenderer renderer = objectWeHit.GetComponent<MeshRenderer>();

          // Set the renderer to use the material we want to use.
          renderer.material = materialToChangeTo;
        }
      }
    }
	}
}
