using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  
    public void OnClick() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void Quit() 
   {
    Application.Quit();
    Debug.Log("User left the game");
   }
   public void Back() 
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
  
}
