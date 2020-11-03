using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement speed in meters per sec")] [SerializeField] float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float horizontal=Input.GetAxis("Horizontal");
    float vertical=Input.GetAxis("Vertical");
    transform.Translate(new Vector3(horizontal,vertical,0)* speed*Time.deltaTime);
    transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15.5f,15.5f),Mathf.Clamp(transform.position.y, -4.2f, 4.2f) ,transform.position.z);

    }
}
