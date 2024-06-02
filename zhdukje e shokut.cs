using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhdukjeeshokut : MonoBehaviour
{
    public float spawnrate = 0.2f;
    private float timer = 0;
    private float timer2 = 0;
    public float opacity = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
            opacity -= Time.deltaTime*3.3f;
        }
        else{
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, opacity);
            timer = 0;
            
        }
        if (timer2 < 0.4f)
        {
            timer2 += Time.deltaTime;
        }
        else{
            timer2 = 0f;
            Destroy(gameObject);
        }
    }
}
