using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
   public void StartGameButton()
    {
       
        SceneManager.LoadScene(1);
    }



    public void ExitGame()
    {
        
            Application.Quit();
        
    }
}
