using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerHigher : MonoBehaviour
{
    
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
