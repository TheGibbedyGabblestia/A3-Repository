using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
        public GameObject player;
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public text pickupText;

    public Audiosource[] audioSources;
    public float audioProximity = 5.0f;

    void update(){
        levelCompleteCheck();
        UpdateGui();
        PlayAudioSamples();
    }

    private void levelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }
 
    private void UpdateGui(){
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }
    private void PlayAudioSamples(){
        for (int i - 0; i < audioSources.Length; i++){
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity){
                if(!audioSources[i].isPlaying){
                    audioSources[i].Play();
                }
            }
        }
    }
}   

 
