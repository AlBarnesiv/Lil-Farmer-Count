using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Number4 : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;

    // Method to handle button click
    public void Four(){
        GameManager.instance.number = 4;
        StartCoroutine(ClickFour());
    }

    private IEnumerator ClickFour(){
        // Play sound
            audioSource.clip = soundEffect;
            audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(3);
    }  
}
