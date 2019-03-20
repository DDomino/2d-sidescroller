using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    

    public void GameOver()
    {
        Debug.Log("GameOver");
        SceneManager.LoadScene("GameOverSceen");
    }
    public void MenuScreen()
    {
        SceneManager.LoadScene("Menu Screen");
    }
    public void GameScene()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
