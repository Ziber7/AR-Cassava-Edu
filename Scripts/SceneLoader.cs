using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int angkaScene;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("costT", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneButton(int angkaScene)
    {
        SceneManager.LoadScene(angkaScene);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
