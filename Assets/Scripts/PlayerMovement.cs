using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 4;
    [SerializeField] private Rigidbody2D playerRigidBody;
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        playerRigidBody.linearVelocity = new Vector2(horizontal, vertical) * speed;


    }
}
