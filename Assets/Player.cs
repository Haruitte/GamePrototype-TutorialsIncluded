using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    private float horizontalInput;
    private float forwardInput;
    public float rotateSpeed = 360f; // degrees per second
    public bool isOnGround = true;
    public float jumpForce = 4.0f;
    public Rigidbody body;
    [SerializeField] private Transform CamRotator;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Vector3 cameraForward = CamRotator.forward; //Overwrites the angle offset of the camera
        cameraForward.y = 0;

        Vector3 direction = cameraForward * forwardInput + CamRotator.right * horizontalInput;

        if (horizontalInput > 0 || horizontalInput < 0 || forwardInput > 0 || forwardInput < 0)
        {
            //body.velocity = new Vector3(horizontalInput * CamRotator.right.x * speed, body.velocity.y, forwardInput * CamRotator.forward.z * speed);
            //Vector3 v = new Vector3 (horizontalInput * transform.right.x * speed, body.velocity.y, forwardInput * transform.forward.z * speed);
            body.velocity = direction * speed;
            Quaternion newDirection = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newDirection, rotateSpeed * Time.deltaTime); //interpolation
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) // Jump
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

}
