using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    public void awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown){
                StartBounce(); 
        }
    }
    void StartBounce(){

        Vector2 randomDirection = new Vector2(Random.Range(-1,1),1);
        
        rb.AddForce(randomDirection * bounceForce,ForceMode2D.Impulse);
    }
}
