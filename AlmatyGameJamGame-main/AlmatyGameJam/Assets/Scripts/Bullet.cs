using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public bool isRight;

    void Start()
    {
        Destroy(gameObject, 1.5f);
        isRight = PlayerControl.instance.isFacingRight;
    }

    void Update()
    {
        if(isRight) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

}
