using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField][Range(0.1f, 1f)] float rotationSpeed;

    void Start()
    {

    }


    void Update()
    {
        LightRotation();
    }

    private void LightRotation()
    {
        /*
        Vector3 lookPos = playerTransform.position - transform.position;
        lookPos.y = 0f;
        Quaternion newRotation = Quaternion.LookRotation(lookPos);
        */
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, rotationSpeed);
        transform.Rotate(0, 90 * rotationSpeed * Time.deltaTime, 0);
    }
}
