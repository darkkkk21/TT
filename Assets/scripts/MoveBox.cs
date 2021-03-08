using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector2.down * InstBox.instance.speed * Time.deltaTime);
        
        
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
            InstBox.instance.spawned = false;
        }
    }
}
