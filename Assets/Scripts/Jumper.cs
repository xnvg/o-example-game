using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField]float timeToWait = 3f;

    private MeshRenderer mRenderer;
    Rigidbody mRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        mRigidbody = GetComponent<Rigidbody>();

        mRenderer.enabled = true;
        mRigidbody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Jump up:"+Time.time);
        if(Time.time>timeToWait)
        {
            transform.Translate(0,3,0);
            timeToWait += 3;
        }
         
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
