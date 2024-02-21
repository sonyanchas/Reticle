using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float MinY;
    [SerializeField] float MaxY;
    [SerializeField] float MinX;
    [SerializeField] float MaxX;
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
        if (transform.position.y > MaxY)
        {
            transform.position = new Vector3(transform.position.x, MaxY, 0f);
        }
        if (transform.position.y < MinY)
        {
            transform.position = new Vector3(transform.position.x, MinY, 0f);
        }
        if (transform.position.x > MaxX)
        {
            transform.position = new Vector3(MaxX, transform.position.y, 0f);
        }
        if (transform.position.x < MinX)
        {
            transform.position = new Vector3(MinX, transform.position.y, 0f);
        }
        if (Input.GetButton("Fire1") == true)
            {
            AudioSource audioSource;
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
    }
    
    
                         