using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            //this triggers when T is pressed
            Debug.Log("T Pressed");
        }
    }
}
