using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float movementspeed = 10f;
    public float deadzone = -45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movementspeed) * Time.deltaTime;
        if(transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    
    
    
    }
}
