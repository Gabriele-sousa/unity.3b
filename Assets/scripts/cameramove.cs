using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
   public bool travarMouse = true;
   public float sensibilitie = 5.0f;
   private float mouseX = 0f;
   private float mouseY = 0f;
   public float speed = 0.02f;

    void Start()
    {
        if (!travarMouse){
            return;
        }
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensibilitie * speed;
        mouseY -= Input.GetAxis("Mouse Y") * sensibilitie * speed;
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
       
    }
}