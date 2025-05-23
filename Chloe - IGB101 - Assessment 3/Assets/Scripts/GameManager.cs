using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
   
    public GameObject player;

        //Pickup and Level Copmpletion Logic
        public int currentPickups = 0;
        public int maxPickups = 5;
        public bool levelComplete = false;

        public Text pickupText;

    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    // Update is called once per frame
    void Update(){
        LevelCompleteCheck();
        UpdateGUI();
    }

    private void LevelCompleteCheck(){
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    private void UpdateGUI(){
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }
}
