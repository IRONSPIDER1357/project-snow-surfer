using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    Rigidbody2D myRigidbody2d;
    [SerializeField] float torqueAmount = 1f; 
     Vector2 moveVector;
     [SerializeField] float baseSpeed = 25f;
     [SerializeField] float boostSpeed = 30f;
     SurfaceEffector2D surfaceEffector2D;
    bool canControlPlayer = true;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        myRigidbody2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        if(canControlPlayer)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }

    void RotatePlayer()
    {
        moveVector = moveAction.ReadValue<Vector2>();

        //rotates the character left or right based on player's input
        if (moveVector.x < 0)
        {
            myRigidbody2d.AddTorque(torqueAmount);
        }
        else if (moveVector.x > 0)
        {
            myRigidbody2d.AddTorque(-torqueAmount); 
        }
    }

    void BoostPlayer()
    {
        if(moveVector.y > 0)
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    public void disableControls()
    {
        canControlPlayer = false;
    }
}
