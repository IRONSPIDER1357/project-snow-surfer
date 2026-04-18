using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    Rigidbody2D myRigidbody2d;
    [SerializeField] float torqueAmount = 1f; 

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        myRigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveVector;
        moveVector = moveAction.ReadValue<Vector2>();
        if(moveVector.x < 0)
        {
            myRigidbody2d.AddTorque(torqueAmount);
        }
        else if (moveVector.x > 0)
        {
            myRigidbody2d.AddTorque(-torqueAmount); 
        }
    }
}
