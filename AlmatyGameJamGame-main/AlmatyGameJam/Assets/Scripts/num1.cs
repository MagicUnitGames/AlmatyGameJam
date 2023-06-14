using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class num1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI SumTxt1;




    public button btn;

    public int negb;
 
    void Start()
    {
        SumTxt1 = GetComponent<TextMeshProUGUI>();

       
        //b = Random.Range(-9, +9);
       

    

        //SumTxt.text = d.ToString();

        //SumTxt1.text = btn.b.ToString();

        if(btn.b >= 0)
        {
            SumTxt1.text = " + " + btn.b.ToString();
        }

        if (btn.b < 0)
        {
            negb = Mathf.Abs(btn.b);
            SumTxt1.text = " - " + negb.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (btn.b >= 0)
        {
            SumTxt1.text = " + " + btn.b.ToString();
        }

        if (btn.b < 0)
        {
            negb = Mathf.Abs(btn.b);
            SumTxt1.text = " - " + negb.ToString();
        }
    }
}
