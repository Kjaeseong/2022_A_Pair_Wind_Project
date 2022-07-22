using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public enum CharClass
    { 
        PALADIN,
        ARCHER,
        ASSASSIN,
        ASTROLOGER
    }

    [SerializeField] private int _selectClass = 0;

    public float Hp;
    public float Sp;
    public float Power;
    public float Defense;
    public float Knockback;

    private int ComboCount;
    private bool _attacking;
    private bool _moving;
    private bool _defending;
    private bool _jumping;

    private float _attackCooltime = 1f;
    private float _moveSpeed = 0.1f;
    private float _spRecoverySpeed = 1f;

    private PlayerInput _input;


    // Start is called before the first frame update
    void Awake()
    {
        _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
