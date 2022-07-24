using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    public PlayerCharacter P1;

    private float _scaleX = 2f;
    private float _scaleY = 2f;
    private float _scaleZ = 2f;

    private float _posX = 1.5f;
    private float _posY = 2f;
    private float _posZ = 0f;

    private void Awake()
    {
        transform.position = new Vector3(_posX, _posY, _posZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            P1.CanAttack = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            P1.CanAttack = false;
        }
    }
}
