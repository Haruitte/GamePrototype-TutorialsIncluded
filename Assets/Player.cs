using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    private float horizontalInput;
    private float forwardInput;
    public bool isOnGround = true;
    public float jumpForce = 4.0f;
    public Rigidbody body;
    [SerializeField] private Transform CamRotator;

    public Vector2 turn;
    public float sensitivity = 5f;

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
        if (horizontalInput > 0 || horizontalInput < 0 || forwardInput > 0 || forwardInput < 0)
        {
            //body.velocity = new Vector3(horizontalInput * CamRotator.right.x * speed, body.velocity.y, forwardInput * CamRotator.forward.z * speed);
            Vector3 v = new Vector3 (horizontalInput * CamRotator.right.x * speed, body.velocity.y, forwardInput * CamRotator.forward.z * speed);
            body.velocity = v;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) // Jump
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        if (Input.GetAxis("Mouse X") == 1)
        {
            turn.y += Input.GetAxis("Mouse X") + sensitivity;
            transform.localRotation = Quaternion.Euler(0, turn.y, 0);
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
