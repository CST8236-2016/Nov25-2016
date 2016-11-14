using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

  public Material materialToChangeTo;

  public void OnCollisionEnter(Collision collision) {
    //Debug.Log("And I said hey yeah yeah yeah yeah hey yeah yeah.");
    if(materialToChangeTo != null) {
      MeshRenderer renderer = GetComponent<MeshRenderer>();

      // Set the renderer to use the material we want to use.
      renderer.material = materialToChangeTo;
    }
  }
}
