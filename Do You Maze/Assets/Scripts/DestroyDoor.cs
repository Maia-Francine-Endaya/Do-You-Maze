using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
  public GameObject door;
  public GameObject button;

    //Destroys the door instance
    void OnTriggerEnter(Collider other)
    {
      if (other.tag == "Player") 
      {
        Destroy(door);
        Destroy(button);
      }
    }
}
