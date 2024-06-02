using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public bool isMoving;
    public int health = 100;
    generate cameraScript;
    //generate Direksionet;
    //generate ReniiDhomave;

    public Joystick joystick;
    void Start(){

        cameraScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<generate>();
        //Direksionet = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Direksionet>();
        //ReniiDhomave = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ReniiDhomave>();
    }
    void Update()
    {
        movement.x = joystick.Horizontal * moveSpeed;
        movement.y = joystick.Vertical * moveSpeed;
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
        
        isMoving = movement != new Vector2(0,0);

        if (health <= 0){
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "right"){
            if(cameraScript.lastRoomDirection == 2){
                cameraScript.Para();
            }
            else{
                cameraScript.dulDjatht();
                Debug.Log("dul djatht");
            }
        }
        if(collision.gameObject.tag == "left"){
            if(cameraScript.lastRoomDirection == 1){
                cameraScript.Para();
            }
            else{
                cameraScript.dulMajt();
                Debug.Log("dul majt");
            }
            
        }
        if(collision.gameObject.tag == "up"){
            if(cameraScript.lastRoomDirection == 3){
                cameraScript.Para();
            }
            else{
                cameraScript.dulNalt();
                Debug.Log("dul nalt");
            }
            
        }
        if(collision.gameObject.tag == "down"){
            if(cameraScript.lastRoomDirection == 4){
                cameraScript.Para();
            }
            else{
                cameraScript.dulPosht();
                Debug.Log("dul posht");
            }
        }
    }
    public void ghostHit(){
        health = health - 15;
    }
    public void pinkHit(){
        Debug.Log("pink");
        health = health - 10;
    }
}
