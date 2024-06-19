using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    void Update()
    {
       /*  // Check for touch input
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {   
            // Loads Animal Selection Screen
            SceneManager.LoadScene(1);
        } */

        // Check for mouse input
        if (Input.GetMouseButtonDown(0))
        {
            // Loads Animal Selection Screen
            SceneManager.LoadScene(1);
        }
    }

}
