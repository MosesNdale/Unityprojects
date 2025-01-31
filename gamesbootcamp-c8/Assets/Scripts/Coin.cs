using UnityEngine;

public class Coin : MonoBehaviour
{
    public float amplitude = 1.0f;
    public float frequency = 1.0f;

    private float startY;

    private void Start()
    {
        startY = transform.position.y;
    }

    private void Update()
    {
        float offset = Mathf.Sin(frequency * Time.time) * amplitude;
        offset = startY + offset;

        Vector3 finalPosition = transform.position;
        finalPosition.y = offset;
        transform.position = finalPosition;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<RollerBallManager>().CoinCollected();
            Destroy(gameObject);
        }
    }
}
