using UnityEngine;
using System.Collections;

public class CheckTriggerCollision : MonoBehaviour {

  /* If you're working with a triggered collision (intersection),
   * this is called when the triggered collision starts. */
  void OnTriggerEnter(Collider collider) {
    Debug.Log(collider.gameObject.name + " entered the trigger!");
  }

  /* If you're working with a triggered collision (intersection),
   * this is called as the triggered collision continues to occur. */
  void OnTriggerStay(Collider collider) {
    Debug.Log(collider.gameObject.name + " stayed in the trigger!");
  }

  /* If you're working with a triggered collision (intersection),
   * this is called when the triggered collision ends. */
  void OnTriggerExit(Collider collider) {
    Debug.Log(collider.gameObject.name + " exited the trigger!");
  }

  // If you're doing standard collision.
  void OnCollisionEnter(Collision collision) {

  }
}
