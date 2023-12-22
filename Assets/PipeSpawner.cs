
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        //  Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
    if (timer < SpawnRate)
    { 
        timer = timer + Time.deltaTime;
     }

     else
     {
        Spawnpipe();
         timer = 0;

     }
  
    void Spawnpipe()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowestpoint ,highestpoint ) , 0), transform.rotation);
    }
    
       
    
}
}