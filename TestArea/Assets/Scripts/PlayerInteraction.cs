using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerInteraction : MonoBehaviour
{


    float raycastDistance = 3; 

    public TMP_Text interactText; 

    public TMP_Text Score;

    public int Counter = 0;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

        RaycastHit hit; 

        Score.text = "Item Count:" + Counter + "/4";


        if (Physics.Raycast(ray, out hit, raycastDistance)) 
        {
            
            if (hit.collider.CompareTag("Item"))
            {
                interactText.text = "Press [E] to read the note."; 
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("[E] Was Pressed while looking at a note, lets open the note.");
                    Counter += 1;
                    Destroy(hit.transform.gameObject);


                }
          
             
            }

            else //If nothing at all with an above tag was hit with the Raycast within the specified distance then run this
            {
                if (interactText.text != "")//If the interactText is not already set as nothing then set it to nothing - this is to help optimise and save from constantly spamming this request
                {
                    interactText.text = ""; //Removing the text as nothing was detected by the raycast
                }
            }
        }
    }
}
