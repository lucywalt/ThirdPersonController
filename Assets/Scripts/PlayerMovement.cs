using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody capsuleRigidBody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpSpeed = 5f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private InputManager inputManager;
     void Start()
    {
        //adding MovePlater as a listener to the OnMove event
        inputManager.OnMove.AddListener(MovePlayer);
    }

    private bool isGrounded = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground")) // Check if touching ground
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground")) // Check if leaving ground
        {
            isGrounded = false;
        }
    }

    private bool IsGrounded()
    {
        return isGrounded;
    }
    public void MovePlayer(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        capsuleRigidBody.AddForce(inputXZPlane * ballSpeed);
    }

    public void Jump()
    {
        if (IsGrounded()) // Prevents double jumping
        {
            capsuleRigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }
}
