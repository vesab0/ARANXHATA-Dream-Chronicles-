using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class roomsLeft : MonoBehaviour
{
    generate cameraScript;
   public TextMeshProUGUI RoomLeftText;

   public int rooms;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<generate>();
    
    }

    void Update(){
        rooms = 8 - cameraScript.j;
        RoomLeftText.text = rooms.ToString();
    }
    
}
