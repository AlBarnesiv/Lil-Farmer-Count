using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Number5 : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;

    // Method to handle button click
    public void Five(){
        GameManager.instance.number = 5;
        StartCoroutine(ClickFive());
    }

    private IEnumerator ClickFive(){
        // Play sound
            audioSource.clip = soundEffect;
            audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(3);
    }  
}
