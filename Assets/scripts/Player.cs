using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float screen;
    private float speed = 2;

    private float maxLength = 1.7f;
    private float minLength = -1.7f;

    

    

    // Start is called before the first frame update
    void Start()
    {
        
        screen = Screen.width;
        
    }

    
    void Update()
    {
       

        int i = 0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > screen/2 && transform.position.x < maxLength)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);


            }

            if (Input.GetTouch(i).position.x < screen / 2 && transform.position.x > minLength)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }

            ++i;
        }

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("box"))
        {
            
           Destroy(gameObject);
            
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    
}
