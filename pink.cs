using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pink : MonoBehaviour
{
    public int health = 60;
    PlayerMovement playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "shock")
            {
                health = health - 20;
            }
        if (other.gameObject.tag == "Player"){
            playerScript.pinkHit();
        }
    }
}
