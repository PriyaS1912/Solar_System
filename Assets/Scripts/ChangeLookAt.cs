using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // Declare a gameObject variable which defines the target where the camera should LookAt
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = gameObject;  // Corrected this.GameObject to gameObject
            Debug.Log("Look at target not specified. Defaulting to parent Object");
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 200);
    }
}
