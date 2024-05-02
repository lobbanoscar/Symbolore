using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signage : MonoBehaviour
{
    public Transform goalPosition;
    public int distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Vector3.Distance(transform.position, goalPosition.position))<=distance)
        {
            transform.position = goalPosition.position;
        }
    }
}
