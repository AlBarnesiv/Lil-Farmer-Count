using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoatButton : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource audioSource;


    // Method to handle button click
    public void Goat()
    {
        GameManager.instance.goat = true;
        StartCoroutine(ClickGoat());
    }
    
    private IEnumerator ClickGoat (){
    // Play sound
        audioSource.clip = soundEffect;
        audioSource.Play();

        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(2);
    
    }
}
