using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CowButton : MonoBehaviour
{
public AudioClip soundEffect;
    public AudioSource audioSource;


    // Method to handle button click
    public void Cow()
    {
        GameManager.instance.cow = true;
        StartCoroutine(ClickCow());
    }
    
    private IEnumerator ClickCow (){
    // Play sound
        audioSource.clip = soundEffect;
        audioSource.Play();

        yield return new WaitForSeconds(audioSource.clip.length);

        // Change screen
        SceneManager.LoadScene(2);
    
    }
}
