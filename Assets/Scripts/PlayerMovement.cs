using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector3 moveVector;
    CharacterController character;


    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Update()
    {
        character.Move(moveVector * Time.deltaTime);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 direction = movementValue.Get<Vector2>();
        //print(direction);
        moveVector = new Vector3(direction.x, 0, direction.y);
    }


    public void OnFire()
    {
        //print("fire");
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;

    }
}
