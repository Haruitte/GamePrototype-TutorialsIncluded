using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    private float horizontalInput;
    private float forwardInput;
    public float jumpForce = 4.0f;
    public Rigidbody body;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // float input = Input.GetAxis("Horizontal");
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        //transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        //transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        body.AddForce(Vector3.right * speed * horizontalInput);
        body.AddForce(Vector3.forward * speed * forwardInput);
    }


}
