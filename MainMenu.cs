using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // SceneManager.LoadScene(1);
        SceneManager.LoadSceneAsync(1);
       
    }

    public void Reward(){

        SceneManager.LoadSceneAsync(2);
    }
    
    public void InsertCode(){

        SceneManager.LoadSceneAsync(3);
    }

    public void GoToTouchpad()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
