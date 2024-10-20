using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScript : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");      
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
