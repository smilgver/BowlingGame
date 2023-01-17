using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigidbody;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (GameManager.ballThrown == false)
        {
            MoveBall(Input.GetAxisRaw("Horizontal"));
        }
        ThrowBall(2500f); //replace float with actual throw strength
    }

    void ThrowBall(float throwStrength)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.forward * throwStrength);
            GameManager.ballThrown = true;
        }
    }
    void MoveBall(float horizontalAxis)
    {
        transform.position += (Vector3.right * horizontalAxis * Time.deltaTime);
    }
}
