using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PigButton : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;


    // Method to handle button click
    public void Pig()
    {
        GameManager.instance.pig = true;
        StartCoroutine(ClickPig());
    }
    
    private IEnumerator ClickPig (){
    // Play sound
        audioSource.clip = soundEffect;
        audioSource.Play();

        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(2);
    
    }
}
