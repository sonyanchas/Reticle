using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CloudMover : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float minX;
    [SerializeField] Vector3 move;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Time.deltaTime * Speed * Vector3.left);

        if (transform.position.x < minX)
        {
            transform.position = move;
        }
    }
}
