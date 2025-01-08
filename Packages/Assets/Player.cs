using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    private float horizontalInput;
    private float forwardInput;
    public float rotateSpeed = 360f; // degrees per second
    public int isOnGround = 0;
    public float jumpForce = 4.0f;
    public Rigidbody body;
    Vector3 direction;
    Vector3 cameraForward;
    [SerializeField] private Transform CamRotator;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        isOnGround = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DetectMovement();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }


    private void DetectMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        cameraForward = CamRotator.forward; //Overwrites the angle offset of the camera
        cameraForward.y = 0;
        ApplyJump();
    }



    private void ApplyMovement()
    {
      
        ApplyWalking();
    }

    private void ApplyWalking()
    {
        direction = cameraForward * forwardInput + CamRotator.right * horizontalInput;
        if (horizontalInput != 0 || forwardInput != 0)
        {
            //body.velocity = new Vector3(horizontalInput * CamRotator.right.x * speed, body.velocity.y, forwardInput * CamRotator.forward.z * speed);
            //Vector3 v = new Vector3 (horizontalInput * transform.right.x * speed, body.velocity.y, forwardInput * transform.forward.z * speed);
            body.velocity = new Vector3(direction.x * speed, body.velocity.y, direction.z * speed);
            Quaternion newDirection = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newDirection, rotateSpeed * Time.fixedDeltaTime); //interpolation
        }
    }

    private void ApplyJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround > 0) // Jump //isOnGround set as int to account for multiple items as ground, when in air value will go to zero
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround += 1;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround -= 1;
        }
    }

}
