using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
   public GameObject Door;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
  
    void OnTriggerEnter(Collider col) {
         if (col.CompareTag("Player"))
        {
            Door.GetComponent<Animator>().SetBool("open",true);
        }
    }
}
