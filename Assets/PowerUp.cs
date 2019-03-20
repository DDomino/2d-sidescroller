using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public GameObject player;
    public GameObject effects;

    public float speed = 10;


    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            player.GetComponent<MovementController>().SpeedBoost(speed);


            Debug.Log("Touched power up");
            playParticals();
            Destroy(this.gameObject);
            

        }

    }

    void playParticals()
    {
        GameObject effectIns = (GameObject)Instantiate(effects, transform.position, transform.rotation); //Spawn a bullet shatter effect
        Destroy(effectIns, 2f);
    }


}
