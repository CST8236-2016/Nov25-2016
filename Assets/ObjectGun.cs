using UnityEngine;
using System.Collections;

public class ObjectGun : MonoBehaviour {

  // The GameObject reference for the object we want to shoot.
  public GameObject objectToShoot;

  public Vector2 maxAngles;
	
	// Update is called once per frame
	void Update () {
    Vector2 mousePosition = Input.mousePosition;

    Camera thisCamera = GetComponent<Camera>();

    // Get the size of the screen, and the center for use later.
    Vector2 screenSize = new Vector2(Screen.width, Screen.height);
    Vector2 screenCenter = screenSize / 2.0f;

    // Get the vector that represents how far you are from the center.
    Vector2 difference = mousePosition - screenCenter;
    Vector2 deltaPercentage = new Vector2(difference.x / screenCenter.x, difference.y / screenCenter.y);

    Vector2 newAngle = new Vector2(deltaPercentage.x * maxAngles.x, deltaPercentage.y * maxAngles.y);

    transform.localRotation = Quaternion.Euler(-newAngle.y, newAngle.x, 0.0f);

    // Check to see if the mouse has been clicked.
    if(Input.GetMouseButtonDown(0)) {
      GameObject newObject = GameObject.Instantiate(objectToShoot, transform.position, Quaternion.identity) as GameObject;

      Rigidbody bulletRB = newObject.GetComponent<Rigidbody>();
      
      // Use the direction the camera is facing as the basis for applying our force.
      bulletRB.AddForce(transform.forward * 40.0f, ForceMode.Impulse);
    }
	}
}
