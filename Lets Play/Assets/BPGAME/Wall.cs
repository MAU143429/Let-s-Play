using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    float speed;
    float height;

    string input;
    public bool isRight;
    public bool isUp = false;


    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
        speed = 5f;
    }

    public void Init(bool isRightWall, int wallpos)
    {
        isRight = isRightWall;

        Vector2 pos = Vector2.zero;
        if (isRightWall)
        {

            if (wallpos == 1)
            {
                pos = new Vector2(10, 3);
            }
            else if (wallpos == 2)
            {
                pos = new Vector2(10, -3);
            }
            else if (wallpos == 5)
            {
                pos = new Vector2(0, -5);
            }
            else if (wallpos == 6)
            {
                pos = new Vector2(0, 5);
            }

        }
        else
        {

            if (wallpos == 3)
            {
                pos = new Vector2(-10, 3);
            }
            else if (wallpos == 4)
            {
                pos = new Vector2(-10, -3);
            }


        }

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

