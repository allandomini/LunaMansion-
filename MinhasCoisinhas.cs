using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinhasCoisinhas : MonoBehaviour
{
    
    public Animator Animator;

     public LayerMask Tree;

    // Start is called before the first frame update
    void Start()
    {
        
        
             
        
     
    }
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
             Animator.SetBool("ground", false);
               Animator.SetBool("treefino",true);
            
        }
    }
    // Update is called once per frame
}
