using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour
{
    // Start is called before the first frame update
    public AlienButtons ab;
    public Equations equations;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ab.clicked1 == true && equations.randint == equations.sum1)
        {
            gameObject.transform.position = new Vector3(-7.5f, gameObject.transform.position.y);
        }

        if (ab.clicked2 == true && equations.randint == equations.sum2)
        {
            gameObject.transform.position = new Vector3(-2.25f, gameObject.transform.position.y);
            

        }

        if (ab.clicked3 == true && equations.randint == equations.sum3)
        {
            gameObject.transform.position = new Vector3(2.95f, gameObject.transform.position.y);

        }

        if (ab.clicked4 == true && equations.randint == equations.sum4)
        {
            gameObject.transform.position = new Vector3(8.1f, gameObject.transform.position.y);

        }
    }
}
