using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Equations : MonoBehaviour
{
    // Start is called before the first frame update


    TextMeshProUGUI Text1;
    TextMeshProUGUI Text2;
    TextMeshProUGUI Text3;
    TextMeshProUGUI Text4;
    TextMeshProUGUI Playertxt;
    GameObject PlayerC;
    public int a1;
    public int b1;
    public int a2;
    public int b2;
    public int a3;
    public int b3;
    public int a4;
    public int b4;
    public int sum1;
    public int sum2;
    public int sum3;
    public int sum4;
    public int randomsum;

    public string strsum1;
    public string strsum2;
    public string strsum3;
    public string strsum4;

    public GameObject ufotxt1;
    public GameObject ufotxt2;
    public GameObject ufotxt3;
    public GameObject ufotxt4;
    public GameObject sumtxt;

    public AlienButtons alienButtons;
    public GameOver gameOver;

    
    public bool correct = false;
    public bool correctufo = false;
    public bool correctl = true;

    public float randint;
    void Start()
    {

        Text1 = GameObject.Find("ufo1txt").GetComponent<TextMeshProUGUI>();
        Text2 = GameObject.Find("ufo2txt").GetComponent<TextMeshProUGUI>();
        Text3 = GameObject.Find("ufo3txt").GetComponent<TextMeshProUGUI>();
        Text4 = GameObject.Find("ufo4txt").GetComponent<TextMeshProUGUI>();
        Playertxt = GameObject.Find("playertxt").GetComponent<TextMeshProUGUI>();
        PlayerC = GameObject.Find("Player");


        a1 = Random.Range(4, 7);
        b1 = Random.Range(-4, 4);
        
        sum1 = a1 + b1;

        
        if (b1 < 0)
        {
            Text1.text = a1.ToString() + " - " + Mathf.Abs(b1).ToString();
            
        }

        if (b1 == 0 || b1 > 0)
        {
            Text1.text = a1.ToString() + " + " + b1.ToString();
        }
        


        a2 = Random.Range(4, 7);
        b2 = Random.Range(-4, 4);

        sum2 = a2 + b2;


        if (b2 < 0)
        {
            Text2.text = a2.ToString() + " - " + Mathf.Abs(b2).ToString();

        }

        if (b2 == 0 || b2 > 0)
        {
            Text2.text = a2.ToString() + " + " + b2.ToString();
        }
        

        a3 = Random.Range(4, 7);
        b3 = Random.Range(-4, 4);

        sum3 = a3 + b3;


        if (b3 < 0)
        {
            Text3.text = a3.ToString() + " - " + Mathf.Abs(b3).ToString();
            
        }

        if (b3 == 0 || b3 > 0)
        {
            Text3.text = a3.ToString() + " + " + b3.ToString();
        }
        

        a4 = Random.Range(4, 7);
        b4 = Random.Range(-4, 4);

        sum4 = a4 + b4;


        if (b4 < 0)
        {
            Text4.text = a4.ToString() + " - " + Mathf.Abs(b4).ToString();

        }

        if (b4 == 0 || b4 > 0)
        {
            Text4.text = a4.ToString() + " + " + b4.ToString();
        }
        

        strsum1 = sum1.ToString();
        strsum2 = sum2.ToString();
        strsum3 = sum3.ToString();
        strsum4 = sum4.ToString();

        string[] sums = { strsum1, strsum2, strsum3, strsum4 };
        string randsum = sums[Random.Range(0, sums.Length)];
        Playertxt.text = randsum;

        randint = int.Parse(randsum);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alienButtons.clicked1 == true && randint == sum1)
        {
            a1 = Random.Range(4, 7);
            b1 = Random.Range(-4, 4);

            sum1 = a1 + b1;


            if (b1 < 0)
            {
                Text1.text = a1.ToString() + " - " + Mathf.Abs(b1).ToString();

            }

            if (b1 == 0 || b1 > 0)
            {
                Text1.text = a1.ToString() + " + " + b1.ToString();
            }
            correct = true;
            correctufo = true;
            PlayerC.transform.position = new Vector2(150, PlayerC.transform.position.y);

            alienButtons.UFObutton1.transform.position = new Vector2(alienButtons.UFObutton1.transform.position.x, 300);

            alienButtons.laser1.SetActive(true);
            alienButtons.laser2.SetActive(false);
            alienButtons.laser3.SetActive(false);
            alienButtons.laser4.SetActive(false);

        }

        if (alienButtons.clicked1 == true && randint != sum1)
        {
            correctl = false;
            
        }

            if (alienButtons.clicked2 == true && randint == sum2)
        {
            a2 = Random.Range(4, 7);
            b2 = Random.Range(-4, 4);

            sum2 = a2 + b2;


            if (b2 < 0)
            {
                Text2.text = a2.ToString() + " - " + Mathf.Abs(b2).ToString();

            }

            if (b2 == 0 || b2 > 0)
            {
                Text2.text = a2.ToString() + " + " + b2.ToString();
            }
            correct = true;
            correctufo = true;
            PlayerC.transform.position = new Vector2(355, PlayerC.transform.position.y);

            alienButtons.UFObutton2.transform.position = new Vector2(alienButtons.UFObutton2.transform.position.x, 300);

            alienButtons.laser1.SetActive(false);
            alienButtons.laser2.SetActive(true);
            alienButtons.laser3.SetActive(false);
            alienButtons.laser4.SetActive(false);
        }

        if (alienButtons.clicked2 == true && randint != sum2)
        {
            correctl = false;
            
        }

        if (alienButtons.clicked3 == true && randint == sum3)
        {
            a3 = Random.Range(4, 7);
            b3 = Random.Range(-4, 4);

            sum3 = a3 + b3;


            if (b3 < 0)
            {
                Text3.text = a3.ToString() + " - " + Mathf.Abs(b3).ToString();

            }

            if (b3 == 0 || b3 > 0)
            {
                Text3.text = a3.ToString() + " + " + b3.ToString();
            }

            correct = true;
            correctufo = true;
            PlayerC.transform.position = new Vector2(555, PlayerC.transform.position.y);

            alienButtons.UFObutton3.transform.position = new Vector2(alienButtons.UFObutton3.transform.position.x, 300);

            alienButtons.laser1.SetActive(false);
            alienButtons.laser2.SetActive(false);
            alienButtons.laser3.SetActive(true);
            alienButtons.laser4.SetActive(false);
        }

        if (alienButtons.clicked3 == true && randint != sum3)
        {
            correctl = false;
            
        }

        if (alienButtons.clicked4 == true && randint == sum4)
        {
            a4 = Random.Range(4, 7);
            b4 = Random.Range(-4, 4);

            sum4 = a4 + b4;


            if (b4 < 0)
            {
                Text4.text = a4.ToString() + " - " + Mathf.Abs(b4).ToString();

            }

            if (b4 == 0 || b4 > 0)
            {
                Text4.text = a4.ToString() + " + " + b4.ToString();
            }
            correct = true;
            correctufo = true;
            PlayerC.transform.position = new Vector2(755, PlayerC.transform.position.y);

            alienButtons.UFObutton4.transform.position = new Vector2(alienButtons.UFObutton4.transform.position.x, 300);
            alienButtons.laser1.SetActive(false);
            alienButtons.laser2.SetActive(false);
            alienButtons.laser3.SetActive(false);
            alienButtons.laser4.SetActive(true);
        }

        if (alienButtons.clicked4 == true && randint != sum4)
        {
            correctl = false;
            
        }

        if (alienButtons.isclicked == true && correct == true)
        {
            strsum1 = sum1.ToString();
            strsum2 = sum2.ToString();
            strsum3 = sum3.ToString();
            strsum4 = sum4.ToString();

            string[] sums = { strsum1, strsum2, strsum3, strsum4 };
            string randsum = sums[Random.Range(0, sums.Length)];
            Playertxt.text = randsum;

            randint = int.Parse(randsum);
        }

        
        
    }
}
