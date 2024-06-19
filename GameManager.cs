using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager instance = null;

    // Game states
    public bool dog = false;
    public bool duck = false;
    public bool cow = false;
    public bool goat = false;
    public bool pig = false;
    public int number = 0;
    public int spawnNumber = 1;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else if(instance!=this){
            Destroy(gameObject);   
        }
        DontDestroyOnLoad(gameObject);
    }
}

