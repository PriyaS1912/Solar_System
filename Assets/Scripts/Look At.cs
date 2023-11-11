using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // where the camera should look at
    public static GameObject target;  // Changed to public for visibility in the Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = gameObject;  // Corrected this.GameObject to gameObject
            Debug.Log("Look at target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
    }
}

