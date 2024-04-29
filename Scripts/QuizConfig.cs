using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizConfig : MonoBehaviour
{
    public GameObject currentQ;
    public GameObject nextQ;
    public Text scoreUser, correct;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("value", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rightA ()
    {
        currentQ.SetActive(false);
        nextQ.SetActive(true);
        int score = PlayerPrefs.GetInt("value");
        score += 1;
        correct.text = score.ToString();
        PlayerPrefs.SetInt("value", score);
        score = score * 5;
        scoreUser.text = score.ToString();
    }
    
    public void wrongA ()
    {
        currentQ.SetActive(false);
        nextQ.SetActive(true);
    }
}
