using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_animation_3 : MonoBehaviour
{

    Animator door_animator;

    // Start is called before the first frame update
    void Start()
    {
        door_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Collider){
        if(Input.GetKey("k")){
            if(door_animator.GetBool("Door_Open")){
                door_animator.SetBool("Door_Open", false);
            }else{
                door_animator.SetBool("Door_Open", true);
            }

        }
    }


   // void OnTriggerExit(Collider Collider){
//
  //  }

}
