using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    int jump = 0;
    int jumplimit = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(jump < jumplimit){
                Debug.Log("space bar pressed");
                Debug.Log(jump);
                GetComponent<Rigidbody>().AddForce(Vector3.up*5 , ForceMode.VelocityChange);
                jump ++;
            }
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            GetComponent<Rigidbody>().AddForce(Vector3.forward*3 , ForceMode.VelocityChange); 
        }
    if(Input.GetKeyDown(KeyCode.LeftArrow)){
        GetComponent<Rigidbody>().AddForce(Vector3.back*3 , ForceMode.VelocityChange);
    }
        
    }

    void OnCollisionEnter(Collision collision ){
        jump = 0;
    }
}
