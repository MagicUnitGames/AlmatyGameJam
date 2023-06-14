using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class button : MonoBehaviour
{
    public bool correctans = false;

    public Player player;

    public num nuum;
    public num1 nuum1;
    //public num2 nuum2;
    public TextMeshProUGUI buttxt;
    public TextMeshProUGUI buttxt1;
    public TextMeshProUGUI buttxt2;
    public int d;
    public int rnd;
    public int rndnum;
    public int rndnum1;

    public bool ispressed = false;
    public bool ispressed1 = false;
    public bool ispressed2 = false;
    public bool ispressed3 = false;
    public bool startpressed = false;

    

    public Color green;
    public Color red;
    public Button button1;
    public Button button2;
    public Button button3;

    public int a;
    public int b;
    public bool tm = false;
    //public int c;

    public float curtime = 0;
    public float maxtime = 1;

    public GameObject canvas;
    public GameObject startb;
    public GameObject correct;
    public GameObject incorrect;

    public void Button1()
    {
        ispressed = true;
        ispressed1 = true;
        ispressed2 = false;
        ispressed3 = false;
        curtime = 0;
    }

    public void Button2()
    {
        ispressed = true;
        ispressed2 = true;
        ispressed1 = false;
        ispressed3 = false;
        curtime = 0;

    }

    public void Button3()
    {
        ispressed = true;
        ispressed3 = true;
        ispressed2 = false;
        ispressed1 = false;
        curtime = 0;

    }

    public void Startb()
    {
        startpressed = true;
        ispressed = false;
        ispressed3 = false;
        ispressed2 = false;
        ispressed1 = false;
        canvas.SetActive(true);
        startb.SetActive(false);
        curtime = 0;

    }

    private void Start()
    {
        player.speed = 0;
        canvas.SetActive(false);
        startb.SetActive(true);
        correct.SetActive(false);
        incorrect.SetActive(false);
        

        a = Random.Range(0, 10);
            b = Random.Range(-a, 15);
            //c = Random.Range(11, 20);
            rndnum = Random.Range(0, 5);
            rndnum1 = Random.Range(6, 20);
            buttxt = GetComponent<TextMeshProUGUI>();
            rnd = Random.Range(1, 4);
            d = a + b;
            ispressed = false;
        

        if (rndnum == d || rndnum1 == d)
        {
            rndnum = d + 2;
            rndnum1 = d - 3;
        }
    }



    void Update()
    {
            if (rnd == 1)
            {
                buttxt.text = d.ToString();
                buttxt1.text = rndnum1.ToString();
                buttxt2.text = rndnum.ToString();
                if (ispressed1 == true)
                {
                    print("1");
                correct.SetActive(true);
                incorrect.SetActive(false);
                correctans = true;
                player.speed += 3;
                    
                }
            if (ispressed3 == true || ispressed2 == true)
            {
                correct.SetActive(false);
                incorrect.SetActive(true);
                player.speed -= 0.5f;
                correctans = false;
            }

        }



            if (rnd == 2)
            {
                buttxt1.text = d.ToString();
                buttxt2.text = rndnum1.ToString();
                buttxt.text = rndnum.ToString();
                if (ispressed2 == true)
                {
                    print("2");
                correct.SetActive(true);
                incorrect.SetActive(false);
                correctans = true;
                player.speed += 3;
            }
            if (ispressed1 == true || ispressed3 == true)
            {
                correct.SetActive(false);
                incorrect.SetActive(true);
                player.speed -= 0.5f;
                correctans = false;
            }

        }



            if (rnd == 3)
            {
                buttxt2.text = d.ToString();
                buttxt1.text = rndnum.ToString();
                buttxt.text = rndnum1.ToString();
                if (ispressed3 == true)
                {
                    print("3");
                correct.SetActive(true);
                incorrect.SetActive(false);
                correctans = true;
                player.speed += 3;
            }
            
                if(ispressed1 == true || ispressed2 == true)
            {
                correct.SetActive(false);
                incorrect.SetActive(true);
                player.speed -= 0.5f;
                correctans = false;
            }
            }
            
            ispressed1 = false;
            ispressed2 = false;
            ispressed3 = false;


        if (curtime > maxtime)
        {
            correct.SetActive(false);
            incorrect.SetActive(false);
            
        }

        if(curtime > 0.5f)
        {
            player.speed = 2;
            
        }
        curtime += Time.deltaTime;
        


        if (ispressed == true)
        {
            a = Random.Range(0, 10);
            b = Random.Range(-a, 15);
            //c = Random.Range(11, 20);
            rndnum = Random.Range(-10, 5);
            rndnum1 = Random.Range(6, 20);
            buttxt = GetComponent<TextMeshProUGUI>();
            rnd = Random.Range(1, 4);
            d = a + b;
            ispressed = false;
            if (rndnum == d || rndnum1 == d)
            {
                rndnum = d + 2;
                rndnum1 = d - 3;
            }
        }
        
    }

}