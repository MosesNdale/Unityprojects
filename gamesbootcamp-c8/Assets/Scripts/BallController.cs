using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rBody;
    public int resetY = -10;

    public AudioSource source;
    public AudioClip clip;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (transform.position.y < resetY) 
        {
            GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
            gameManager.GameOver();
        }
    }

}
