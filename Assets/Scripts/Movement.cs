using UnityEngine;
using UnityEngine.Playables;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody Rigidbody;
    private float horizontal;

    [SerializeField]
    private float moveSpeed = 5f;


    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        

    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            Rigidbody.linearVelocity = new Vector2(horizontal * moveSpeed, Rigidbody.linearVelocity.y);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

           Rigidbody.linearVelocity = new Vector2(horizontal * moveSpeed, Rigidbody.linearVelocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
           

    }
}
