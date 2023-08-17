using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 dir = new Vector3(0, mouseX, 0);



        transform.eulerAngles = transform.eulerAngles + dir * speed * Time.deltaTime;

    }
}
