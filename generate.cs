using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject player;
    public GameObject rightDoor;
    public Transform playertrans;
    // djathtas 1 
    // majtas 2
    // posht 3
    // nalt 4
    int[,] dhomatKejt = { {-29,-1,-10}, {-29,-12,-10}, {-29,-23,-10} };
    int[,] karakteriTP1 = { {-38,-1,-1}, {-38,-12,-1}, {-38,-24,-1}};
    int[,] karakteriTP2 = { {-20,-1,-1}, {-20,-12,-1}, {-20,-24,-1}};
    int[,] karakteriTP3 = { {-30,2,-1}, {-30,-9,-1}, {-30,-20,-1}};
    int[,] karakteriTP4 = { {-30,-4,-1}, {-30,-15,-1}, {-30,-26,-1}};

    public List<int> ReniiDhomave = new List<int>() {0};
    public List<int> Direksionet = new List<int>(){0};
    public int lastRoom;
    public int lastRoomDirection;
    int RndB;
    int Dhoma;
    public int j;
    public int x;
    public int Shop;


    void Start()
    {
        var random = new System.Random();
        Shop = random.Next(2,8);
        Debug.Log(Shop);
    }

    void Update()
    {
        if (j>1){
            lastRoom = ReniiDhomave[ReniiDhomave.Count - 2 - x];
            lastRoomDirection = Direksionet[Direksionet.Count - 1 - x];
        }
        if (j == 8){
            lastLVL();
        }
        
    }
   
    public void dulDjatht(){
        var RndB = new System.Random();
        var Dhoma = RndB.Next(0,3);
        
        ReniiDhomave.Add(Dhoma);
        transform.position = new Vector3(dhomatKejt[Dhoma,0], dhomatKejt[Dhoma,1], dhomatKejt[Dhoma,2]);
        Direksionet.Add(1);
        playertrans.transform.position = new Vector3(karakteriTP1[Dhoma,0],karakteriTP1[Dhoma,1],karakteriTP1[Dhoma,2]);
        j = j +1;
        if (j == Shop){
            Debug.Log("SHOPPP");
            gotoShop();
        }
    }
    public void dulMajt(){
        var RndB = new System.Random();
        var Dhoma = RndB.Next(0,3);
        j = j +1;
        playertrans.transform.position = new Vector3(karakteriTP2[Dhoma,0],karakteriTP2[Dhoma,1],karakteriTP2[Dhoma,2]);
        ReniiDhomave.Add(Dhoma);
        transform.position = new Vector3(dhomatKejt[Dhoma,0], dhomatKejt[Dhoma,1], dhomatKejt[Dhoma,2]);
        Direksionet.Add(2);
        if (j == Shop){
            Debug.Log("SHOPPP");
            gotoShop();
        }
        
    }
    public void dulPosht(){
        var RndB = new System.Random();
        var Dhoma = RndB.Next(0,3);
        j = j +1;
        playertrans.transform.position = new Vector3(karakteriTP3[Dhoma,0],karakteriTP3[Dhoma,1],karakteriTP3[Dhoma,2]);
        ReniiDhomave.Add(Dhoma);
        transform.position = new Vector3(dhomatKejt[Dhoma,0], dhomatKejt[Dhoma,1], dhomatKejt[Dhoma,2]);
        Direksionet.Add(3);
        if (j == Shop){
            Debug.Log("SHOPPP");
            gotoShop();
        }
    }
    public void dulNalt(){
        var RndB = new System.Random();
        var Dhoma = RndB.Next(0,3);
        j = j +1;
        playertrans.transform.position = new Vector3(karakteriTP4[Dhoma,0],karakteriTP4[Dhoma,1],karakteriTP4[Dhoma,2]);
        ReniiDhomave.Add(Dhoma);
        transform.position = new Vector3(dhomatKejt[Dhoma,0], dhomatKejt[Dhoma,1], dhomatKejt[Dhoma,2]);
        Direksionet.Add(4);
        if (j == Shop){
            Debug.Log("SHOPPP");
            gotoShop();
        }
    }
    public void Para(){
        Debug.Log("Kthehu");

        x = x+1;
        j = j-1;

        transform.position = new Vector3(dhomatKejt[lastRoom,0], dhomatKejt[lastRoom,1], dhomatKejt[lastRoom,2]);
        if (lastRoomDirection == 2){
            playertrans.transform.position = new Vector3(karakteriTP1[lastRoom,0],karakteriTP1[lastRoom,1],karakteriTP1[lastRoom,2]);
        }
        if (lastRoomDirection == 1){
            playertrans.transform.position = new Vector3(karakteriTP2[lastRoom,0],karakteriTP2[lastRoom,1],karakteriTP2[lastRoom,2]);
        }
        if (lastRoomDirection == 3){
            playertrans.transform.position = new Vector3(karakteriTP4[lastRoom,0],karakteriTP4[lastRoom,1],karakteriTP4[lastRoom,2]);
        }
        if(lastRoomDirection == 4){
            playertrans.transform.position = new Vector3(karakteriTP3[lastRoom,0],karakteriTP3[lastRoom,1],karakteriTP3[lastRoom,2]);
        }
        if (j == Shop){
            Debug.Log("SHOPPP");
            gotoShop();
        }

    }
    public void lastLVL(){
        transform.position = new Vector3 (-29,-34,-10);
        if (lastRoomDirection == 2){
            playertrans.transform.position = new Vector3(-38,-34,0);
        }
        if (lastRoomDirection == 1){
            playertrans.transform.position = new Vector3(-20,-34,0);
        }
        if (lastRoomDirection == 3){
            playertrans.transform.position = new Vector3(-29,-30,0);
        }
        if(lastRoomDirection == 4){
            playertrans.transform.position = new Vector3(-29,-38,0);
        }
    }
    public void gotoShop(){
        transform.position = new Vector3 (-29,-46,-10);
        if (lastRoomDirection == 2){
            playertrans.transform.position = new Vector3(-37,-46,0);
        }
        if (lastRoomDirection == 1){
            playertrans.transform.position = new Vector3(-21,-46,0);
        }
        if (lastRoomDirection == 3){
            playertrans.transform.position = new Vector3(-29,-43,0);
        }
        if(lastRoomDirection == 4){
            playertrans.transform.position = new Vector3(-29,-49,0);
        }
    }
}

