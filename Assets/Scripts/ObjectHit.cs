using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        // if(other.gameObject.name == ''){

        // }
        //Debug.Log("Wall-chan: Kimochiiii!"+ other.gameObject.name);
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
