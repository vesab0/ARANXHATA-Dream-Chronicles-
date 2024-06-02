using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
   [SerializeField] GameObject gameObject;
    public GameObject clearButton;
    public GameObject enterButton;
    public TMP_InputField NumpadInputField;
    

   
    
    public void clearEvent(){
        NumpadInputField.text= null;
    }
    public void enterEvent (){
        if (NumpadInputField != null){
            gameObject.SetActive(true);
            Debug.Log("Success");
        }
        else{
            gameObject.SetActive(false);
            Debug.Log("Fail");
        }
    }

}
