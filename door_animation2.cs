using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_animation2 : MonoBehaviour
{

    public string door_animation_name = "Door_Open"; //animasyon adı

    public string key_to_open_door = "k"; //hangi tuş ile kapı açılsın?

    public GameObject player; //oyuncunun kapıya mesafesini anlamak için kullanılacak.

    private Animator door_animator;

    void Start()
    {
        door_animator = GetComponent<Animator>();
    }


    void Update()
    {
        
        if((transform.position - player.transform.position).magnitude < 2f){
            if(Input.GetKey(key_to_open_door)){
                if(door_animator.GetBool(door_animation_name)){
                    door_animator.SetBool(door_animation_name, false);
                }else{
                    door_animator.SetBool(door_animation_name, true);
                }
            }
        }

    }
}
