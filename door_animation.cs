using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_animation : MonoBehaviour
{

    GameObject[] doors;
    GameObject player;
    string door_animation_name = "Door_Open";
    //Animator animator;


    void Start(){

        doors = GameObject.FindGameObjectsWithTag("door");

    }

    void Update(){

        for(int i=0;i<doors.Length;i++){
            GameObject door = doors[i];

            Animator d_a = door.GetComponent<Animator>();

            if((door.transform.position - player.transform.position).magnitude < 2f){

                if(d_a.GetBool(door_animation_name)){
                    d_a.SetBool(door_animation_name,false);
                }else{
                    d_a.SetBool(door_animation_name,true);
                }

            }



        }

    }



/*

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void open_door(){
        
        animator.SetBool("Door_Open",true);
    }

    public void close_door(){
        animator.SetBool("Door_Open",false);
    }


*/

}
