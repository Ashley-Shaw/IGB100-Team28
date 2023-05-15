using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextAreaTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider otherObject)
    {

        if (otherObject.transform.tag == "Player")
        {
            SceneManager.LoadScene(sceneBuildIndex:1);

        }
    }
}
