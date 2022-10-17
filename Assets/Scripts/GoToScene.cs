using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public string sceneName = "New Scene name here";

    public bool isAutomatic;
    private bool manualEnter;
    
    // AUTOMATIC telleport
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (isAutomatic)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    // MANUAL teleport
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (!isAutomatic && manualEnter)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    private void Update()
    {
        if (!isAutomatic && !manualEnter)
        {
            manualEnter = Input.GetButtonDown("Fire1");
        }
    }
}
