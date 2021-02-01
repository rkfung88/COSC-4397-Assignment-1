using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorzi = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorzi, 0.0f, moveVert);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

    }
}
