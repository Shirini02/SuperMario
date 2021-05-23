using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gameovercontroller : MonoBehaviour
{
    public GameObject Gameoverpanel;
    // Start is called before the first frame update
    public void Exit()
    {
        SceneManager.LoadScene(2);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnBack()
    {
        SceneManager.LoadScene(0);
    }
}
