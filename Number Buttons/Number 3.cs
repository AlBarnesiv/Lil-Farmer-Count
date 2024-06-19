using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Number3 : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;

    // Method to handle button click
    public void Three(){
        GameManager.instance.number = 3;
        StartCoroutine(ClickThree());
    }

    private IEnumerator ClickThree(){
        // Play sound
            audioSource.clip = soundEffect;
            audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(3);
    }  
}
