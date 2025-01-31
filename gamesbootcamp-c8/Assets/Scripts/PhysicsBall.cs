using UnityEngine;

public class PhysicsBall : MonoBehaviour
{
    public Rigidbody rb;

    [Tooltip("This dictates the force magnitude")]
    public float strength;

    private float xInput;
    private float zInput;
    private Vector3 inputDir;
    private Transform cameraTransform;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    { 
        inputDir = new Vector3(xInput, 0, zInput);

        float yaw  = cameraTransform.rotation.eulerAngles.y;
        inputDir = Quaternion.Euler(0, yaw, 0) * inputDir;
        rb.AddForce(inputDir * strength);
       
    }
}
