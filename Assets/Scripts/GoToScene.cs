using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public string sceneName = "New Scene name here";

    public string uuid;

    public bool isAutomatic;
    private bool manualEnter;
    
    // AUTOMATIC teleport
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

    private void Teleport (string objName)
    {
        if (objName == "Player")
        {
            if (isAutomatic || (!isAutomatic && manualEnter))
            {
                FindObjectOfType<PlayerController>().nextUuid = uuid;
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
