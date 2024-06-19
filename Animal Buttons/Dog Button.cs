using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DogButton : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;


    // Method to handle button click
    public void Dog()
    {
        GameManager.instance.dog = true;
        StartCoroutine(ClickDog());
    }
    
    private IEnumerator ClickDog (){
    // Play sound
        audioSource.clip = soundEffect;
        audioSource.Play();

        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(2);
    
    }
}
