using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class num : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI SumTxt;


    //public int a;

    public button btn;

    public int d;
    void Start()
    {
        SumTxt = GetComponent<TextMeshProUGUI>();

        //a = Random.Range(0, 10);
       

       

        //SumTxt.text = d.ToString();
        SumTxt.text = btn.a.ToString();
      
    }

    // Update is called once per frame
    void Update()
    {
        SumTxt.text = btn.a.ToString();
    }
}
