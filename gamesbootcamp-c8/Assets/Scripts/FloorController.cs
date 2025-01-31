using UnityEngine;

public class FloorController : MonoBehaviour
{
    public float speed = 2.0f;

    Vector3 currentRotation = Vector3.zero;
    float horzInput;
    float vertInput;

    void Update()
    {

        horzInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");


        currentRotation.x += vertInput * speed * Time.deltaTime;
        currentRotation.z += horzInput * speed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(currentRotation.x,0,currentRotation.z);
    }

}


/*
 
 1. find a font for your game

2. find background music

3. win SFX

4. lose SFX
 
 
 
 
 */