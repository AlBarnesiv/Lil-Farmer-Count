using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Number2 : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;

    // Method to handle button click
    public void Two(){
        GameManager.instance.number = 2;
        StartCoroutine(ClickTwo());
    }

    private IEnumerator ClickTwo(){
        // Play sound
            audioSource.clip = soundEffect;
            audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(3);
    }  
}
