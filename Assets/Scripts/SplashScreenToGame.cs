using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenToGame : MonoBehaviour
{
    public GameObject backGroundMusic;
    public GameObject splashBackGround;
    public GameObject splashAllText;

   
    void Start()
    {
        StartCoroutine(SplashToGame());
    }

    IEnumerator SplashToGame()
    {
        yield return new WaitForSeconds(4);
        backGroundMusic.SetActive(true);

        yield return new WaitForSeconds(1);
        splashAllText.SetActive(false);
        splashBackGround.SetActive(false);
    }
}
