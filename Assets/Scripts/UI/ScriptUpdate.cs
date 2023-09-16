using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScriptUpdate : MonoBehaviour
{
    public GameObject scoreDisplay;


    void Start()
    {
        scoreDisplay.GetComponent<TextMeshPro>().text = "SCORE: 100";
    }

}
