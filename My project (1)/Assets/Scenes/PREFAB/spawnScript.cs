using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject objectToSpawn;   
    public KeyCode spawnKey = KeyCode.Space; 
    public Transform spawnPoint;       

    void Start()
    {

        if (spawnPoint == null)
        {
            spawnPoint = this.transform;
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(spawnKey))
        {

            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
