using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaMove : MonoBehaviour
{
   public Animator anim;
    
    public float Vel;

   
    
    void FixedUpdate()
   
   {  
       
    
       
       Vel = Input.GetAxis("Vertical");
     
        anim.SetBool("treefino", true);
        anim.SetFloat("isWalkin", Vel);
       

       
   }
       public void Example()
    {
        // Sets "newParent" as the new parent of the child GameObject.
       
        // Same as above, except worldPositionStays set to false
        // makes the child keep its local orientation rather than
        // its global orientation.
     

        // Setting the parent to ‘null’ unparents the GameObject
        // and turns child into a top-level object in the hierarchy
       
    }
 

}
