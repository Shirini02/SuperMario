using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneContoller : MonoBehaviour
{
    public GameObject toppanel, middlepanel,helppanel;
    public void GoToNextScene()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToFirstScene()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToBeginScene()
    {
        SceneManager.LoadScene(0);
    }
    public void back()
    {
        toppanel.SetActive(true);
        middlepanel.SetActive(true);
       helppanel.SetActive(false);

    }
    public void Help()
    {
        helppanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
   


}
