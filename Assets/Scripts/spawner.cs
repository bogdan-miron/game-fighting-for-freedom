using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyPlayer;
    public Transform spawnLocation;
    //giving it a random value 
    // Start is called before the first frame update
    void Start()
    {
        bool isSpawnig = (Random.value > 0.5f);
        if(isSpawnig == true)
        {
            Instantiate(enemyPlayer, spawnLocation);
        }
        
    }

    //fara update function 

    
}
