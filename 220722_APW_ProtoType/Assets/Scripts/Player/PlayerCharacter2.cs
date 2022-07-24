using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter2 : MonoBehaviour
{
    public enum CharClass
    { 
        PALADIN,
        ARCHER,
        ASSASSIN,
        ASTROLOGER
    }

    public bool ChooseCharactor = false;

    [SerializeField] private int _selectClass = 0;

    public float Hp = 120f;
    public float Sp = 100f;
    public float Power = 8f;
    public float Defense = 15f;
    public float Knockback = 2f;
    public Vector3 NormalAttack_Scale = new Vector3(2f, 2f, 2f);

    private int ComboCount;
    private bool _attacking;
    private bool _moving;
    private bool _defending;
    private bool _jumping = false;
    private int _direction = 1;

    [SerializeField] private float _attackCooltime = 1f;
    [SerializeField] private float _moveSpeed = 0.1f;
    [SerializeField] private float _spRecoverySpeed = 1f;
    [SerializeField] private float _jumpForce = 100f;
    [SerializeField] private float _downForce = 10f;

    private Rigidbody _rigid;


    // Start is called before the first frame update
    void Awake()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();

        ActionInput();
    }

    private void MoveInput()
    {
        _rigid.AddForce(0f, -1 * _downForce, 0f);

        if (ChooseCharactor)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _rigid.AddForce(0f, _jumpForce, 0f);
                _jumping = true;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {

            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1 * _moveSpeed, 0f, 0f);
                transform.localScale = new Vector3(-1 * _direction, 1f, 1f);
                _moving = true;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(_moveSpeed, 0f, 0f);
                transform.localScale = new Vector3(_direction, 1f, 1f);
                _moving = true;
            }
            else 
            {
                _moving = false;
            }
        }
    }

    private void ActionInput()
    {
        if (ChooseCharactor)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Player02_Atk");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Player02_Skiil_1");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("Player02_Skiil_2");

            }
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
