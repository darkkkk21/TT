using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstBox : MonoBehaviour
{
    public static InstBox instance;


    public GameObject box;
    public GameObject spawner;
    public bool spawned;


    public float speed;
    public float increaseSpeed;
    private float time;
    public float endTime;



    // Start is called before the first frame update
    void Start()
    {
        instance = GetComponent<InstBox>();
        time = endTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;

        if (time <= 0)
        {
            speed = speed + increaseSpeed;
            time += endTime;
        }

        if (!spawned) 
        { 
            SpawnerBox();
           
        }
        
    }
    private void SpawnerBox()
    {   
        float rand = Random.Range(-2f, 2f);
        
        spawner.transform.localPosition = new Vector2(rand,4);

        Instantiate(box, spawner.transform.position , Quaternion.identity);

        spawned = true;
    }
}
