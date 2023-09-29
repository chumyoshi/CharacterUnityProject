using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;
    public KeyCode crouchKey = KeyCode.C;


    private void Update()
    {

        if (Input.GetKey(crouchKey))
        {
            transform.position = cameraPosition.position + new Vector3(0, 1, 0);
        }


        else
        {
            transform.position = cameraPosition.position + new Vector3(0, 2.5f, 0);
        }

    }

}
