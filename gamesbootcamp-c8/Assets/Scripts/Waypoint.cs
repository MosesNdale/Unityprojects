using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            audioSource.PlayOneShot(clip);
        }


        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}
