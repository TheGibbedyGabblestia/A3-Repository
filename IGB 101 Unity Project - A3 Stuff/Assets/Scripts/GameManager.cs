using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text pickupText;
    //Pickup and level completion logic
    public int currentPickups = 0;
    public int maxPickups = 15;
    public bool levelComplete = false;
    //Audio proxiity logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levelCompleteCheck();
        updateGUI();
    }

    private void levelCompleteCheck()
    {
        if (currentPickups >= maxPickups) 
            levelComplete = true;
        else
            levelComplete = false;
    }

    private void updateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }

    //loop for playing audio proximity events - Audiosource based
    private void PlayAudioSamples()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying){
                    audioSources[i].Play();
                }
            }
        }
    }
}
