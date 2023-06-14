using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Calculate : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI SumTxt;
    public TextMeshProUGUI SumTxt1;
    public TextMeshProUGUI SumTxt2;

    public int a;

    public int b;
    public int c;

    public int d;
    void Start()
    {
        SumTxt = GetComponent<TextMeshProUGUI>();

     a = Random.Range(-10, 10);
     b = Random.Range(-9, 9);
     c = Random.Range(-9, 9);
        
        d = a + b + c;

        //SumTxt.text = d.ToString();
        SumTxt.text = a.ToString();
        SumTxt1.text = b.ToString();
        SumTxt2.text = c.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
