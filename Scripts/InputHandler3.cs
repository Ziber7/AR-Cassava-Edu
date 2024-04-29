using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Reflection;

public class InputHandler3 : MonoBehaviour
{
    [SerializeField] InputField a1,a2,b1;
    [SerializeField] Text r1,r2,r3,r4,resultA,result1,result2,resultTotal,harvest;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateInput()
    {
        int na1 = int.Parse(a1.text);
        int na2 = int.Parse(a2.text);
        int nb1 = int.Parse(b1.text); // harvest
        int nb3 = na2;

        int t1 = (na1 * na2);
        int t2 = (nb1 * na1 * na2);
        int tIncome = t2;
        int t3 = t2;
        int tCost = PlayerPrefs.GetInt("costT");
        int t4 = tIncome - tCost;

        r1.text = resultS(t1);
        r2.text = na2.ToString();
        r3.text = resultS(t2);
        r4.text = (na1 * nb1).ToString(); // Qty = harvest x qty KG
        resultA.text = resultS(t2);
        harvest.text = nb1.ToString();
        result1.text = resultS(tIncome);
        result2.text = resultS(tCost);
        

        if (t4 > 0)
        {
            resultTotal.text = resultS(t4);
        }
        else 
        {
            //resultText.text = "Rp " + n1.ToString("G3", en-US);
            resultTotal.text = "Invalid Input";
            Debug.Log("Invalid Input");
        }

    }

    public string resultS(int s)
    {
        string s0 = s.ToString("C");
        string s1 = s0.Remove(0,1);
        if (s == 0) 
        {
            string s2 = "-";
            return s2;
        } else {
            string s2 = "Rp " + s1;
            return s2;
        }
    }
}
