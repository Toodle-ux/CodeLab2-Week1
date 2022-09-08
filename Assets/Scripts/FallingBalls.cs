using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBalls : MonoBehaviour
{
    public int addScore;
    
    // add score when the falling ball hit the ring
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("bang!");
        GameManager.instance.Score = GameManager.instance.Score + addScore;
        Destroy(gameObject);
    }
}
