using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    public int color;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject newObj;

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

        if (newObj != null)
        {
            newObj.transform.position =
                new Vector3(Random.Range(-9, 9), 6, 0);
        }
        

        //GameObject go = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject;
        //int num = GetComponent<ColorPicker>().SetSprite();
        //go.GetComponent<SpriteRenderer>().sprite = sprites[num];
    }
}
