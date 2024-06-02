using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompSc : MonoBehaviour
{
    public GameObject shock;
    public float spawnrate = 500f;
    private float timer = 0;
    PlayerMovement playerScript;
    

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.isMoving){
            if (timer < spawnrate)
            {
                timer += Time.deltaTime;
            }
            else{
                Instantiate(shock, transform.position,transform.rotation);
                timer = 0;
            }
        }
    }
}
