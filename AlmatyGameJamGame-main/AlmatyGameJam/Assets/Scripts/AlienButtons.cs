using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienButtons : MonoBehaviour
{
    public GameObject UFObutton1;
    public GameObject UFObutton2;
    public GameObject UFObutton3;
    public GameObject UFObutton4;
    public bool isclicked = false;
    public bool clicked1 = false;
    public bool clicked2 = false;
    public bool clicked3 = false;
    public bool clicked4 = false;

    public GameObject laser1;
    public GameObject laser2;
    public GameObject laser3;
    public GameObject laser4;

    public float curtime = 0;
    public float maxtime;

    public Equations equations;
    public void AlienClick1()
    {
        clicked1 = true;
        isclicked = true;
        print("clicked1");
        

        
            //UFObutton1.transform.position = new Vector2(UFObutton1.transform.position.x, 450);
         
    }

    public void AlienClick2()
    {
        clicked2 = true;
        isclicked = true;
        print("clicked2");
        

        
            //UFObutton2.transform.position = new Vector2(UFObutton2.transform.position.x, 450);
          
    }

    public void AlienClick3()
    {
        clicked3 = true;
        isclicked = true;
        print("clicked3");
        
        
           // UFObutton3.transform.position = new Vector2(UFObutton3.transform.position.x, 450);
            
        
    }

    public void AlienClick4()
    {
        clicked4 = true;
        isclicked = true;
        print("clicked4");
        

        
            //UFObutton4.transform.position = new Vector2(UFObutton4.transform.position.x, 450);
            
    }
    private void Update()
    {
        isclicked = false;
        clicked1 = false;
        clicked2 = false;
        clicked3 = false;
        clicked4 = false;

        if(curtime > maxtime)
        {
            laser1.SetActive(false);
            laser2.SetActive(false);
            laser3.SetActive(false);
            laser4.SetActive(false);
            curtime = 0;
        }
        curtime += Time.deltaTime;
        
    }
}
