using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public bool ChooseCharactor = true;
    public float DownForce = 10f;
    public float JumpForce = 400f;
    public float MoveSpeed = 0.1f;
    public bool CanAttack = false;
    private int _direction = 1;

    public float AttackCoolTime = 0.5f;

    private Rigidbody _rigid;
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();

        AttackInput();
        

    }

    private void MoveInput()
    {
        _rigid.AddForce(0f, -1 * DownForce, 0f);
        if (ChooseCharactor)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _rigid.AddForce(0f, JumpForce, 0f);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {

            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1 * MoveSpeed, 0f, 0f);
                transform.localScale = new Vector3(-1 * _direction, 1f, 1f);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(MoveSpeed, 0f, 0f);
                transform.localScale = new Vector3(_direction, 1f, 1f);
            }
        }
    }

    private void AttackInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (CanAttack)
            {
                Debug.Log("Player01_Atk");
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Player01_Skiil_1_On");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Player01_Skiil_2");
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            if (ChooseCharactor)
            {
                ChooseCharactor = false;
            }
            else
            {
                ChooseCharactor = true;
            }
        }
    }
}
