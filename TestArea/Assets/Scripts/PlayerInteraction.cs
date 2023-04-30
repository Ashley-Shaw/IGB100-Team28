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

    public TMP_Text GameOverText;

    public int Counter = 0;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Score.text = "Item Count:" + Counter + "/8";


        if (Physics.Raycast(ray, out hit, raycastDistance))
        {

            if (hit.collider.CompareTag("Item"))
            {
                interactText.text = "Press E to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Counter += 1;
                    Destroy(hit.transform.gameObject);


                }


            }

            else if (hit.collider.CompareTag("Door"))
            {
                interactText.text = "Press E to escape";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameOverText.text = "You Escaped!";

                }


            }

            else if (hit.collider.CompareTag("Bars"))
            {
                interactText.text = "Press E to open the door";
                if (Counter == 8)

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Destroy(hit.transform.gameObject);

                    }

            if (Counter < 4)
                {
                    interactText.text = "Not enough collectibles.";
                }
            }

        }

        else
        {
            if (interactText.text != "")
            {
                interactText.text = "";
            }
        }


    }
}