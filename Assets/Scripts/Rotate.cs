using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // declaring a variable to select the rotation target
    public Transform target;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        // You can perform any setup or initialization here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate around the target continuously
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}


