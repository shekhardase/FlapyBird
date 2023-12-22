
using System.Transactions;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D body;
     public LogicManager logic;
    public float multiply;
    // Start is called before the first frame update
    void Start()
    {
        
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            body.velocity = Vector2.up * multiply;
        }
        // body.velocity = Vector2.up * multiply;
        // if(transform.position.y > -15 && transform.position.y < 15)
        // {
        //     logic.GameOver();
        // }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.GameOver();
        Destroy(gameObject);
    }
}
