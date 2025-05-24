using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Pickup : MonoBehaviour { 

    GameManager gameManager;
    void Start() { 
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
}
    private void OnTriggerEnter(Collider otherObject) {
        if (otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }

    }
    
}
