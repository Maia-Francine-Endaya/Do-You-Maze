using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
  public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.tag == "Player") 
      {
        Destroy(door);
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
