using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using TMPro;

public class Score : MonoBehaviour
{
    public int scoreCount;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        scoreCount = 0;
    }

    void Update()
    {
        scoreText.text = scoreCount.ToString("0");
    }
}
