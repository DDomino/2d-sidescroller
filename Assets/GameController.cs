using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform powerUp;




    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("RespawnPowerUp", 0, 2f);
          //  RespawnPowerUp();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    void RespawnPowerUp()
    {
        Instantiate(powerUp.gameObject, new Vector2(powerUp.transform.position.x, powerUp.transform.position.y), Quaternion.identity);
    }
}
