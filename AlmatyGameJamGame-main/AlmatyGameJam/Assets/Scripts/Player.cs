using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public WonLost wl;
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            wl.Canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0);
    }
}
