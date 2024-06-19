using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn1 : MonoBehaviour
{
    // Prefabs
    public GameObject prefabOne;
    public GameObject prefabTwo;
    public GameObject prefabThree;
    public GameObject prefabFour;
    public GameObject prefabFive;
    
    // Number Audio

    // Number Clips
    public AudioClip soundEffectOne;
    public AudioClip soundEffectTwo;
    public AudioClip soundEffectThree;
    public AudioClip soundEffectFour;
    public AudioClip soundEffectFive;

    // Number Sources
    public AudioSource audioSourceOne;
    public AudioSource audioSourceTwo;
    public AudioSource audioSourceThree;
    public AudioSource audioSourceFour;
    public AudioSource audioSourceFive;
    
    // Animal Audio

    // Animal Clips
    public AudioClip soundEffectDog;
    public AudioClip soundEffectCow;
    public AudioClip soundEffectDuck;
    public AudioClip soundEffectGoat;
    public AudioClip soundEffectPig;

    // Anaimal Sources
    public AudioSource audioSourceDog;
    public AudioSource audioSourceCow;
    public AudioSource audioSourceDuck;
    public AudioSource audioSourceGoat;
    public AudioSource audioSourcePig;
    
    // Spawning Number
    int spawnNumber = GameManager.instance.spawnNumber;

    // Bools
    bool hasSpawnedOne = false;
    bool hasSpawnedTwo = false;
    bool hasSpawnedThree = false;
    bool hasSpawnedFour = false;
    bool hasSpawnedFive = false;
    
    void Update(){
       /*  // Touch Screen Controls
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){   
            SpawnCheck();
        } */

        // Mouse Controls (For Testing)
        if (Input.GetMouseButtonDown(0)){
           SpawnCheck();
        }
    }

    private void SpawnCheck(){
        if(GameManager.instance.number >= spawnNumber){
            SpawnNumber();
            StartCoroutine(Count());
        } else if(GameManager.instance.number < spawnNumber){
            SceneManager.LoadScene(4);
        }
    }

    // Method to spawn the number
    public void SpawnNumber(){
        if(spawnNumber == 1 & !hasSpawnedOne){
            Instantiate(prefabOne, new Vector3(-8.67f, 0.32f, 0f), Quaternion.identity);
            hasSpawnedOne = true; // Number 1
        }else if(spawnNumber == 2 & !hasSpawnedTwo){
            Instantiate(prefabTwo, new Vector3(-4.53f, 0.28f, 0f), Quaternion.identity);
            hasSpawnedTwo = true; // Number 2
        }else if(spawnNumber == 3 & !hasSpawnedThree){
            Instantiate(prefabThree, new Vector3(-0.04f, 0.25f, 0f), Quaternion.identity);
            hasSpawnedThree = true; // Number 3
        }else if(spawnNumber == 4 & !hasSpawnedFour){
            Instantiate(prefabFour, new Vector3(4.3611f, 0.2719f, 0f), Quaternion.identity);
            hasSpawnedFour = true; // Number 4
        }else if(spawnNumber == 5 & !hasSpawnedFive){
            Instantiate(prefabFive, new Vector3(8.83f, 0.25f, 0f), Quaternion.identity);
            hasSpawnedFive = true; // Number 5
        }
    }

    private IEnumerator Count(){
        AudioSource currentAudioSource = null;

        // Play sound for Number
        if(spawnNumber == 1){
            audioSourceOne.clip = soundEffectOne;
            audioSourceOne.Play(); // Number 1
            spawnNumber++;
        }else if(spawnNumber == 2){
            audioSourceTwo.clip = soundEffectTwo;
            audioSourceTwo.Play(); // Number 2
            spawnNumber++;
        }else if(spawnNumber == 3){
            audioSourceThree.clip = soundEffectThree;
            audioSourceThree.Play(); // Number 3
            spawnNumber++;
        }else if(spawnNumber == 4){
            audioSourceFour.clip = soundEffectFour;
            audioSourceFour.Play(); // Number 4
            spawnNumber++;
        }else if(spawnNumber == 5){
            audioSourceFive.clip = soundEffectFive;
            audioSourceFive.Play(); // Number 5
            spawnNumber++;
        }

        if (currentAudioSource != null){
            yield return new WaitForSeconds(currentAudioSource.clip.length);
        }
        
        // Play Animal Sounds
        if (GameManager.instance.dog == true){
            audioSourceDog.clip = soundEffectDog;
            audioSourceDog.Play(); // Dog
        } else if (GameManager.instance.cow == true){
            audioSourceCow.clip = soundEffectCow;
            audioSourceCow.Play(); // Cow
        } else if (GameManager.instance.duck == true){
            audioSourceDuck.clip = soundEffectDuck;
            audioSourceDuck.Play(); // Duck
        } else if (GameManager.instance.goat == true){
            audioSourceGoat.clip = soundEffectGoat;
            audioSourceGoat.Play(); // Goat
        } else if (GameManager.instance.pig == true){
            audioSourcePig.clip = soundEffectPig;
            audioSourcePig.Play(); // Pig
        }
    }
}
