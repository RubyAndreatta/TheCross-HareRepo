using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private Vector2 movementInput;
    private Vector3 direction;

    bool hasMoved;


    void Update()
    {
        if (movementInput.x == 0)
        {
            hasMoved = false;
        }
        else if (movementInput.x != 0 && !hasMoved)
        {
            hasMoved = true;
            //GetMovementDirection();
        }



       // (if enter, move forward. trying to go back causes red effect and no movement)
       
    }



    public void GetMovementDirection()
    {
        if (movementInput.x < 0)
        {
            if (movementInput.y > 0)
            {
                direction = new Vector3(-0.5f, 0.5f);
            }
            else if (movementInput.y < 0)
            {
                direction = new Vector3(-0.5f, -0.5f);
            }
            else
            {
                direction = new Vector3(-1, 0, 0);
            }
            transform.position += direction;
        }

        else if (movementInput.x > 0)
        {
            if (movementInput.y > 0)
            {
                direction = new Vector3(0.5f, 0.5f);
            }
            else if (movementInput.y < 0)
            {
                direction = new Vector3(0.5f, -0.5f);
            }
            else
            {
                direction = new Vector3(-1, 0, 0);
            }
            transform.position += direction;
        }

        Debug.Log("e");
    }
}
