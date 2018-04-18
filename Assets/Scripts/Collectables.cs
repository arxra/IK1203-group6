using UnityEngine;

public class Collectables : MonoBehaviour {

  [Tooltip("Value of pickup in score")]
    public int value = 100; 

  void Start(){
  }

  void Update() {
    // Rotate the object around its local X axis at 1 degree per second
    transform.Rotate(Vector3.up * Time.deltaTime * 75);

  }

}

