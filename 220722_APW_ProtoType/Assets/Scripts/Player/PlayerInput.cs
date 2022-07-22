using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool InputUp;
    public bool InputDown;
    public bool InputLeft;
    public bool InputRight;

    public bool InputA;
    public bool InputS;
    public bool InputD;
    public bool InputW;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) { InputUp = true; }
        else { InputUp = false; }

        if (Input.GetKey(KeyCode.DownArrow)) { InputDown = true; }
        else { InputDown = false; }

        if (Input.GetKey(KeyCode.LeftArrow)) { InputLeft = true; }
        else { InputLeft = false; }

        if (Input.GetKey(KeyCode.RightArrow)) { InputRight = true; }
        else { InputRight = false; }

        if (Input.GetKeyDown(KeyCode.A)) { InputA = true; }
        else { InputA = false; }

        if (Input.GetKeyDown(KeyCode.S)) { InputS = true; }
        else { InputS = false; }

        if (Input.GetKeyDown(KeyCode.D)) { InputD = true; }
        else { InputD = false; }

        if (Input.GetKeyDown(KeyCode.W)) { InputW = true; }
        else { InputW = false; }










    }
}
