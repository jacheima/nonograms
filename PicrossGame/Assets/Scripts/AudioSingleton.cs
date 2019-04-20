using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class AudioSingleton : MonoBehaviour
{

    private AudioSource audioSource; //Reference to the Audio

    //This is a singleton that controls the background music. I wanted to make it DontDestoryOnLoad so the music continuously plays throughout the game. 
    void Awake()
    {
        DontDestroyOnLoad(gameObject); //This keeps it from being destroyed from scene to scene
        audioSource = gameObject.AddComponent<AudioSource>(); //This gets the audio source

    }

    void Start()
    {
        audioSource.Play();//This tells the audio to start when the scene is loaded
    }
}