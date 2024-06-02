using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    public GameObject player;
    public Vector2 movement;
    public Transform PlayerT;
    private float distance;
    public Animator animator;
    NavMeshAgent agent;
    PlayerMovement PlayerScript;
    public bool right;
    public bool up;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(PlayerT.position);
        if (PlayerScript.transform.position.x < transform.position.x){
            animator.SetFloat("Hor", 1);
        }
        else{
            animator.SetFloat("Hor",-1);
        }
        if (PlayerScript.transform.position.y > transform.position.y){
            animator.SetFloat("Vertical", 1);
        }
        else{
            animator.SetFloat("Vertical",-1);
        }
    }
}
