using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{
    public Animator animator;
    public float speed = 1f;
    public Vector2 movement;
    public Rigidbody2D rb;
    public float dir = 1;
    public bool Horizontal;
    public int health = 60;
    PlayerMovement playerScript;

    void Start(){
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
    void Update()
    {
        if(Horizontal){
            movement.x = speed+1;
        }
        else{
            movement.y = speed+1;
        }
        animator.SetFloat("Horizontal", movement.x *dir);
        animator.SetFloat("Vertikal", movement.y *dir);

        if (health <= 0){
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime* dir);
        Debug.Log(rb.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            // If the object hits a wall, reverse the direction
            if (other.gameObject.tag == "Wall")
            {
                dir =dir * -1;
                Debug.Log(dir);
            }
            if (other.gameObject.tag == "shock")
            {
                health = health - 20;
            }
            if (other.gameObject.tag == "Player"){
                playerScript.ghostHit();
            }
        }
    }

