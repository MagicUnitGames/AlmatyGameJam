using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UfoOffset : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameOver gameOver;
    public Equations equations;
    //TextMeshProUGUI Playertxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - speed);

       /* GameObject ufo1 = GameObject.Find("Button1");
        GameObject ufo2 = GameObject.Find("Button2");
        GameObject ufo3 = GameObject.Find("Button3");
        GameObject ufo4 = GameObject.Find("Button4");*/
        //Playertxt = GameObject.Find("playertxt").GetComponent<TextMeshProUGUI>();

        if (gameObject.transform.position.y < 0)
        {
            gameOver.MenuActivator();
            
        }

        /*if(ufo1.gameObject.transform.position.y < 200)
        {
            Playertxt.text = equations.strsum1;
        }*/
    }
}
