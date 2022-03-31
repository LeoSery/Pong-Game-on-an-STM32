///////////////////////////////////////////////////////
// STM32 Pong Project - L�o S�ry && Matthias Flament
// ####
// Script to manage the adversary paddle.
// script by L�o S�ry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;

public class AdversaryPaddle : Paddle
{
    private Vector2 _direction;

    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    public void FixedUpdate()
    {
        if (_direction.sqrMagnitude > 0)
        {
            _rigidBody.AddForce(_direction * speed);
        }
    }
}