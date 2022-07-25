using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPaladin : MonoBehaviour
{
    public float HP = 120f;
    public float SP = 100f;
    public float Power = 8f;
    public float Dffence = 12f;
    public float KnockBack = 2f;

    public bool PlayerDie = false;
    public bool ActiveSkill01 = false;
    public bool ActiveSkill02 = false;

    public GameObject _skill01;
    public GameObject _skill02;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (ActiveSkill01)
            { 
                ActiveSkill01 = false;
                _skill01.gameObject.SetActive(false);
            }
            else
            {
                ActiveSkill01 = true;
                _skill01.gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (ActiveSkill02)
            {
                ActiveSkill02 = false;
                _skill02.gameObject.SetActive(false);
            }
            else
            {
                ActiveSkill02 = true;
                _skill02.gameObject.SetActive(true);
            }
        }

        if (HP <= 0)
        {
            PlayerDie = true;
        }
    }

}
