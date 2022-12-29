using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    
    public float speed = 5;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rigidbody2D.velocity = new Vector2(speed, 0);

        
        elapsedTime += Time.deltaTime;

        
        if (elapsedTime >= 3)
        {
            speed += 0.1f;
            elapsedTime = 0;
        }

        
        animator.SetBool("IsRunning", true);
    }
}
