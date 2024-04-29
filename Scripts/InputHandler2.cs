using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Reflection;

public class InputHandler2 : MonoBehaviour
{
    [SerializeField] InputField a1,a2,b1,b2,c1,c2,d1,d2,e1,e2,f1,f2;
    [SerializeField] InputField g1,g2;
    [SerializeField] Text r1,r2,r3,r4,r5,r6,r7,result1,result2,resultTotal;

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
        int nb1 = int.Parse(b1.text);
        int nb2 = int.Parse(b2.text);
        int nc1 = int.Parse(c1.text);
        int nc2 = int.Parse(c2.text);
        int nd1 = int.Parse(d1.text);
        int nd2 = int.Parse(d2.text);
        int ne1 = int.Parse(e1.text);
        int ne2 = int.Parse(e2.text);
        int nf1 = int.Parse(f1.text);
        int nf2 = int.Parse(f2.text);
        int ng1 = int.Parse(g1.text);
        int ng2 = int.Parse(g2.text);

        int t1 = (na1 * na2);
        int t2 = (nb1 * nb2);
        int t3 = (nc1 * nc2);
        int t4 = (nd1 * nd2);
        int t5 = (ne1 * ne2);
        int t6 = (nf1 * nf2);
        int t7 = (ng1 * ng2);

        r1.text = resultS(t1);
        r2.text = resultS(t2);
        r3.text = resultS(t3);
        r4.text = resultS(t4);
        r5.text = resultS(t5);
        r6.text = resultS(t6);
        r7.text = resultS(t7);

        int nt1 = t1+t2+t3;
        int nt2 = t4+t5+t6+t7;
        int nt = nt1+nt2;

        if (nt > 0)
        {
            string totals = nt.ToString("C");
            string totals1 = totals.Remove(0,1);
            resultTotal.text = "Rp " + totals1;

            string t1a = nt1.ToString("C");
            string t1b = t1a.Remove(0,1);
            result1.text = "Rp " + t1b;

            string t2a = nt2.ToString("C");
            string t2b = t2a.Remove(0,1);
            result2.text = "Rp " + t2b;

            //Player Prefs
            PlayerPrefs.SetInt("costT", nt);

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
