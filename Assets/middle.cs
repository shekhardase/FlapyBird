using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle : MonoBehaviour

{
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        logic.addscore();
    }
    }