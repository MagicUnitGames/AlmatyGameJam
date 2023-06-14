using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            health--;
            if(health<=0)
            {
                Destroy(gameObject);
            }

            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("NormalColor", 0.2f);

        }
    }

    public void NormalColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
