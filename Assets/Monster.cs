using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public float MovementSpeed;
   float distance;

    private bool movingRIght = true;

    public Transform GroundDetection;
    public Transform monster;



    private void Update()
    {
        transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.down, 2f);
            if(groundInfo.collider == false)
        {
            if (movingRIght == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRIght = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRIght = true;
            }
        }
    }


    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        movingRIght = !movingRIght;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GroundCheck")){
            
            Destroy(monster.gameObject);
        }

        
    }
}
