using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 100f;
    // float xValue = 0;
    // float yValue = 0.01f;
    // float zValue = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SayHi();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMover();
    }

    void SayHi()
    {
        Debug.Log("Press ASDW or Arrow key to move!");
    }
    void PlayerMover()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //float yValue = 0f;
        transform.Translate(xValue,0,zValue);
    }

}
