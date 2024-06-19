using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    void Awake(){
        if(instance == null){
            instance = this;
        }else if(instance!=this){
            Destroy(gameObject);   
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start(){
        // Load saved volume settings
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        sfxSource.volume = PlayerPrefs.GetFloat("SFXVolume", 0.75f);
    }

    public void SetMusicVolume(float volume){
        musicSource.volume = volume;
    }

    public void SetSFXVolume(float volume){
        sfxSource.volume = volume;
    }
}
