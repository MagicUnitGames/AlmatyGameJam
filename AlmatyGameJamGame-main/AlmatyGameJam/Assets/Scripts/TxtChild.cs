using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtChild : MonoBehaviour
{
    public GameObject UFO;
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, UFO.transform.position.y + 20);
    }
}
