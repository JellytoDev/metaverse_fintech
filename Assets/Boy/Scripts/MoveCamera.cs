using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("newboy").transform;
        print(target);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
        
    }
}
