using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Number1 : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;

    // Method to handle button click
    public void One(){
        GameManager.instance.number = 1;
        StartCoroutine(ClickOne());
    }

    private IEnumerator ClickOne(){
        // Play sound
            audioSource.clip = soundEffect;
            audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(3);
    }  
}
