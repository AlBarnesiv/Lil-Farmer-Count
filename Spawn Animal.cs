using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    // Prefabs

   // Cow Prefabs
   public GameObject prefabCowOne;
   public GameObject prefabCowTwo;
   public GameObject prefabCowThree;
   public GameObject prefabCowFour;
   public GameObject prefabCowFive;

   // Dog Prefabs
   public GameObject prefabDogOne;
   public GameObject prefabDogTwo;
   public GameObject prefabDogThree;
   public GameObject prefabDogFour;
   public GameObject prefabDogFive;

   // Duck Prefabs
   public GameObject prefabDuckOne;
   public GameObject prefabDuckTwo;
   public GameObject prefabDuckThree;
   public GameObject prefabDuckFour;
   public GameObject prefabDuckFive;

   // Goat Prefabs
   public GameObject prefabGoatOne;
   public GameObject prefabGoatTwo;
   public GameObject prefabGoatThree;
   public GameObject prefabGoatFour;
   public GameObject prefabGoatFive;

   // Pig Prefabs
   public GameObject prefabPigOne;
   public GameObject prefabPigTwo;
   public GameObject prefabPigThree;
   public GameObject prefabPigFour;
   public GameObject prefabPigFive;

   // Bools

   // Cow Bools
   bool hasSpawnedCowOne = false;
   bool hasSpawnedCowTwo = false;
   bool hasSpawnedCowThree = false;
   bool hasSpawnedCowFour = false;
   bool hasSpawnedCowFive = false;

   // Dog Bools
   bool hasSpawnedDogOne = false;
   bool hasSpawnedDogTwo = false;
   bool hasSpawnedDogThree = false;
   bool hasSpawnedDogFour = false;
   bool hasSpawnedDogFive = false;

   // Duck Bools
   bool hasSpawnedDuckOne = false;
   bool hasSpawnedDuckTwo = false;
   bool hasSpawnedDuckThree = false;
   bool hasSpawnedDuckFour = false;
   bool hasSpawnedDuckFive = false;

   // Goat Bools
   bool hasSpawnedGoatOne = false;
   bool hasSpawnedGoatTwo = false;
   bool hasSpawnedGoatThree = false;
   bool hasSpawnedGoatFour = false;
   bool hasSpawnedGoatFive = false;

   // Pig Bools
   bool hasSpawnedPigOne = false;
   bool hasSpawnedPigTwo = false;
   bool hasSpawnedPigThree = false;
   bool hasSpawnedPigFour = false;
   bool hasSpawnedPigFive = false;

    // Spawning Number
    int spawnNumber = GameManager.instance.spawnNumber;


    void Update(){
       /* // Touch Screen controls
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){   
            SpawnCheck();
            Debug.Log("Touch Count: " + Input.touchCount);
        } */

        // Mouse Click controls (for testing)
        if (Input.GetMouseButtonDown(0)){
            SpawnCheck();
        }
    }

    private void SpawnCheck(){
        if (GameManager.instance.number >= spawnNumber){
            // Spawns Animal
            SpawnPrefab();
        }
    }

    public void SpawnPrefab(){
        // Spawns Correct Animal in the correct postion
        
        // Cow Spawns
        if(GameManager.instance.cow == true & spawnNumber == 1 & !hasSpawnedCowOne){
            Instantiate(prefabCowOne, new Vector3(-7.69f, -4.01f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.cow == true & spawnNumber == 2 & !hasSpawnedCowTwo){
            Instantiate(prefabCowTwo, new Vector3(-3.26f, -4.03f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.cow == true & spawnNumber == 3 & !hasSpawnedCowThree){
            Instantiate(prefabCowThree, new Vector3(0.84f, -3.69f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.cow == true & spawnNumber == 4 & !hasSpawnedCowFour){
            Instantiate(prefabCowFour, new Vector3(5.14f, -4.06f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.cow == true & spawnNumber == 5 & !hasSpawnedCowFive){
            Instantiate(prefabCowFive, new Vector3(9.57f, -4.06f, 0f), Quaternion.identity);
            spawnNumber++;
        }

        // Dog Spawns
        if(GameManager.instance.dog == true & spawnNumber == 1 & !hasSpawnedDogOne){
            Instantiate(prefabDogOne, new Vector3(-7.84f, -3.84f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.dog == true & spawnNumber == 2 & !hasSpawnedDogTwo){
            Instantiate(prefabDogTwo, new Vector3(-4.07f, -3.78f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.dog == true & spawnNumber == 3 & !hasSpawnedDogThree){
            Instantiate(prefabDogThree, new Vector3(0.85f, -3.6f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.dog == true & spawnNumber == 4 & !hasSpawnedDogFour){
            Instantiate(prefabDogFour, new Vector3(5.35f, -3.66f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.dog == true & spawnNumber == 5 & !hasSpawnedDogFive){
            Instantiate(prefabDogFive, new Vector3(9.27f, -3.67f, 0f), Quaternion.identity);
            spawnNumber++;
        }

        // Duck Spawns
        if(GameManager.instance.duck == true & spawnNumber == 1 & !hasSpawnedDuckOne){
            Instantiate(prefabDuckOne, new Vector3(-8f, -4.1f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.duck == true & spawnNumber == 2 & !hasSpawnedDuckTwo){
            Instantiate(prefabDuckTwo, new Vector3(-3.66f, -4.02f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.duck == true & spawnNumber == 3 & !hasSpawnedDuckThree){
            Instantiate(prefabDuckThree, new Vector3(0.43f, -4.02f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.duck == true & spawnNumber == 4 & !hasSpawnedDuckFour){
            Instantiate(prefabDuckFour, new Vector3(5.32f, -3.91f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.duck == true & spawnNumber == 5 & !hasSpawnedDuckFive){
            Instantiate(prefabDuckFive, new Vector3(9.28f, -4.06f, 0f), Quaternion.identity);
            spawnNumber++;
        }

        // Goat Spawns
        if(GameManager.instance.goat == true & spawnNumber == 1 & !hasSpawnedGoatOne){
            Instantiate(prefabGoatOne, new Vector3(-7.9f, -4.11f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.goat == true & spawnNumber == 2 & !hasSpawnedGoatTwo){
            Instantiate(prefabGoatTwo, new Vector3(-3.77f, -4.11f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.goat == true & spawnNumber == 3 & !hasSpawnedGoatThree){
            Instantiate(prefabGoatThree, new Vector3(0.22f, -3.84f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.goat == true & spawnNumber == 4 & !hasSpawnedGoatFour){
            Instantiate(prefabGoatFour, new Vector3(5.22f, -3.62f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.goat == true & spawnNumber == 5 & !hasSpawnedGoatFive){
            Instantiate(prefabGoatFive, new Vector3(9.17f, -4.2f, 0f), Quaternion.identity);
            spawnNumber++;
        }

        // Pig Spawns
        if(GameManager.instance.pig == true & spawnNumber == 1 & !hasSpawnedPigOne){
            Instantiate(prefabPigOne, new Vector3(-8.0594f, -4.0435f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.pig == true & spawnNumber == 2 & !hasSpawnedPigTwo){
            Instantiate(prefabPigTwo, new Vector3(-4.1f, -4.09f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.pig == true & spawnNumber == 3 & !hasSpawnedPigThree){
            Instantiate(prefabPigThree, new Vector3(0.89f, -3.95f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.pig == true & spawnNumber == 4 & !hasSpawnedPigFour){
            Instantiate(prefabPigFour, new Vector3(5.44f, -4.02f, 0f), Quaternion.identity);
            spawnNumber++;
        }else if(GameManager.instance.pig == true & spawnNumber == 5 & !hasSpawnedPigFive){
            Instantiate(prefabPigFive, new Vector3(9.64f, -4.1f, 0f), Quaternion.identity);
            spawnNumber++;
        }
    }
}
