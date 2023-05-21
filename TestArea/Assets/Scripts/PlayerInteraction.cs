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

    public int goal = 5;
    public int Counter = 0;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Score.text = "Item Count:" + Counter + "/" + goal;


        if (Physics.Raycast(ray, out hit, raycastDistance))
        {

            if (hit.collider.CompareTag("Item"))
            {
                interactText.text = "Press E to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Counter += 1;
                    FindObjectOfType<AudioManager>().Play("Anvil");
                    Destroy(hit.transform.gameObject);
                    


                }


            }

            else if (hit.collider.CompareTag("Door"))
            {
                interactText.text = "Press E to open";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    //GameOverText.text = "You Escaped!";
                    Counter = 0;
                    //goal = 10;
                    Destroy(hit.transform.gameObject);
                }


            }

            else if (hit.collider.CompareTag("Bars"))
            {
                interactText.text = "Press E to unlock";
                if (Counter >= goal)

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Destroy(hit.transform.gameObject);

                    }

            if (Counter < goal)
                {
                    interactText.text = "Not enough collectibles.";
                }
            }

            else if (hit.collider.CompareTag("Door2"))
            {
                interactText.text = "Press E to open";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    //GameOverText.text = "You Escaped!";
                    Counter = 0;
                    //goal = 15;
                    Destroy(hit.transform.gameObject);
                }


            }
            else if (hit.collider.CompareTag("Bars2"))
            {
                interactText.text = "Press E to unlock";
                if (Counter >= goal)

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Destroy(hit.transform.gameObject);

                    }

                if (Counter < goal)
                {
                    interactText.text = "Not enough collectibles.";
                }

                else if (hit.collider.CompareTag("Door3"))
                {
                    interactText.text = "Press E to open";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //GameOverText.text = "You Escaped!";
                        Counter = 0;
                        //goal = 15;
                        Destroy(hit.transform.gameObject);
                    }


                }
                else if (hit.collider.CompareTag("Bars3"))
                {
                    interactText.text = "Press E to unlock";
                    if (Counter >= goal)

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Destroy(hit.transform.gameObject);

                        }

                    if (Counter < goal)
                    {
                        interactText.text = "Not enough collectibles.";
                    }
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