using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float MinY;
    [SerializeField] float MaxY;
    [SerializeField] float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * Speed * y * Vector3.up);
        transform.Translate(Time.deltaTime * Speed * x * Vector3.right);

        //if transform.position.y > MaxY )
       // {
            //transform.position
        //}
    }
}
                         