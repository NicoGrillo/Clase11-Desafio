using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField][Range(0.1f, 5f)] float speed = 1;

    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] bool resetPosition = false;

    void Start()
    {
        if (resetPosition) transform.position = startPoint.position;
    }

    void Update()
    {
        MoveLine();
    }

    private void MoveLine()
    {
        float zLight = transform.localPosition.z;
        float zEnd = endPoint.localPosition.z;
        float zStart = startPoint.localPosition.z;

        if (zLight >= zEnd)
        {
            transform.LookAt(startPoint.position);
            //Debug.Log("To start point");
        }

        if (zLight <= zStart)
        {
            transform.LookAt(endPoint.position);
            //Debug.Log("To end point");
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
