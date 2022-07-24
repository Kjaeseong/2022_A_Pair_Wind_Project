using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool Up;
    public bool Down;
    public bool Left;
    public bool Right;

    public bool A;
    public bool S;
    public bool D;
    public bool W;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            Up = true; 
        }
        else { Up = false; }

        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            Down = true; 
        }
        else { Down = false; }

        if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            Left = true; 
        }
        else { Left = false; }

        if (Input.GetKey(KeyCode.RightArrow)) { Right = true; }
        else { Right = false; }

        if (Input.GetKeyDown(KeyCode.A)) { A = true; }
        else { A = false; }

        if (Input.GetKeyDown(KeyCode.S)) { S = true; }
        else { S = false; }

        if (Input.GetKeyDown(KeyCode.D)) { D = true; }
        else { D = false; }

        if (Input.GetKeyDown(KeyCode.W)) { W = true; }
        else { W = false; }










    }
}
