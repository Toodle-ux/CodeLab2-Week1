using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int score = 0;

    // score property
    public int Score
    {
        get { return score; }
        set { score = value; }
    }


    public TextMeshProUGUI text;

    private void Awake()
    {
        // singleton
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update the score
    void Update()
    {
        text.text = "Score: " + score;
    }
}
