using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegensFollow : MonoBehaviour
{
    public Transform player;
    public GameObject bullet;
    public float movementspd = 1.5f;
    public float lineOfSite;
    public bool isFacingRight = false;
    public bool npcwait;
    void Start()
    {
        isFacingRight = false;
        npcwait = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && npcwait == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, movementspd * Time.deltaTime);

            if (player.position.x > transform.position.x && !isFacingRight)
            {
                Flip();
            }
            else if (player.position.x < transform.position.x && isFacingRight)
            {
                Flip();
            }
        }

        if(Input.GetKeyDown(KeyCode.Space) && npcwait == false) Instantiate(bullet, transform.position, Quaternion.identity);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
