using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("value", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("value", 0);
    }
}
