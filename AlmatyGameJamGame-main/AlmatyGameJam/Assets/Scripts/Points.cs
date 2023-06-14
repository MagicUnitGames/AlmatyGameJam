using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    public Equations equations;
    public TextMeshProUGUI Text;
    public GameOver gameOver;
    public int a = 0;
    public int b;
    
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if(equations.correct == true)
        {
            b = a;
            a++;
            Text.text = a.ToString();
            
        }

        
        equations.correct = false;

    }
}
