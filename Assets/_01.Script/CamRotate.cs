using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamRotate : MonoBehaviour
{

    private void Start()
    {
        //transform.rotation = Quaternion.Euler(0,0,0);

    }

    public float speed = 10f;
    float mx = 0;
    float my = 0;
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mx += mouseX * speed * Time.deltaTime;
        my += mouseY * speed * Time.deltaTime;

        my = Mathf.Clamp(my, -90f, 90f);
        Vector3 dir = new Vector3 (-my, mx, 0);



        transform.eulerAngles = dir;

    }


}
