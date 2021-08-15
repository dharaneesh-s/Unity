using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light myLight;
    

    public void ToggleLight()
    {
        /* if (myLight.enabled == true)
         {
             myLight.enabled = false;

         }
         else
         {
             myLight.enabled = true;
         }*/
        myLight.enabled = !myLight.enabled;
    }
}
