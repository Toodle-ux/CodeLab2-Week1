using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    public int color;

    // spawn a ball once every 0.5 second
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 1);
    }


    void Spawn()
    {
        GameObject newObj;


        // randomly spawn color balls
        color = Random.Range(0, 4);

        switch (color)
        {
            case 0:
                newObj = Instantiate(Resources.Load("Prefabs/Red")) as GameObject;
                break;
            case 1:
                newObj = Instantiate(Resources.Load("Prefabs/Blue")) as GameObject;
                break;
            case 2:
                newObj = Instantiate(Resources.Load("Prefabs/Yellow")) as GameObject;
                break;
            case 3:
                newObj = Instantiate(Resources.Load("Prefabs/Green")) as GameObject;
                break;
            default:
                newObj = null;
                break;
        }

        //balls are spawned at random positions
        if (newObj != null)
        {
            newObj.transform.position =
                new Vector3(Random.Range(-9, 9), 6, 0);
        }
        
    }
}
