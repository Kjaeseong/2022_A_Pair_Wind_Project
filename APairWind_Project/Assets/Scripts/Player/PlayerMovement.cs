using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody _rigid;

    private float _downForce = -10f;
    private float _jumpForce = 900f;

    private float _moveSpeed = 0.1f;

    public bool ActiveAttack = false;
    public bool ActiveSkill01 = false;
    public bool ActiveSkill02 = false;
    public float AttackCoolTime = 1f;
    private float AttackTime = 0f;

    private int _comboCount = 1;

    void Awake()
    {
        _rigid = GetComponent<Rigidbody>();
        _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

        PlayerAction();
    }

    private void PlayerMove()
    {
        _rigid.AddForce(0f, _downForce, 0f);

        if (_input.Up)
        {
            _rigid.AddForce(0f, _jumpForce, 0f);
        }

        if (_input.Down)
        {

        }
        else if (_input.Left)
        {
            transform.Translate(-_moveSpeed, 0f, 0f);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (_input.Right)
        {
            transform.Translate(_moveSpeed, 0f, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }



    private void PlayerAction()
    {
        AttackTime += Time.deltaTime;
        ActiveAttack = false;
        if (_input.A && AttackTime >= AttackCoolTime)
        {
            ActiveAttack = true;
           
            AttackTime = 0f;
        }

        if (_input.S)
        {
            if (ActiveSkill01)      //마나 조건 추가해야함
            {
                ActiveSkill01 = false;
            }
            else
            {
                ActiveSkill01 = true;
            }
        }

        if (_input.D)
        {
            if (ActiveSkill02)      //마나 조건 추가해야함
            {
                ActiveSkill02 = false;
            }
            else
            {
                ActiveSkill02 = true;
            }
        }

        if (_input.W)
        {
            Debug.Log("케릭터 스위칭");
        }
        
    }
}
