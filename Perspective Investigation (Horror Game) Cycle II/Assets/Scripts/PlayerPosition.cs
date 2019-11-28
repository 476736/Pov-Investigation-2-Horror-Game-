using UnityEngine;
using System.Collections;

public class PlayerPosition : MonoBehaviour
{
    public float speed = 10; //how fast the object should rotate

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed);
    }
}


///x = 1-4+23*5
/////x = 118