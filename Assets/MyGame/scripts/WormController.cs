using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode rightArrow;
    public KeyCode leftArrow;

    public Rigidbody z;

    public Vector3 height;
    public Vector3 right;
    public Vector3 left;
    public ForceMode f;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Jump taste wurde gedrückt");
            z.AddForce(height, f);
        }

        if (Input.GetKeyDown(rightArrow))
        {
            Debug.Log("right Arrow wurde gedrückt");
            z.AddForce(right, f);
        }

        if (Input.GetKeyDown(leftArrow))
        {
            Debug.Log("left Arrow wurde gedrückt");
            z.AddForce(left, f);
        }

    }
}
