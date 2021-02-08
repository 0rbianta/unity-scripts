using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class env_mgr : MonoBehaviour
{

    public bool item1_picked = false;
    
    public GameObject player, item1_env_view, item2_env_view, item1_onplayer, item2_onplayer,item1_nottaken,item2_nottaken;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey("1"))
        {
            set_player_item(1);
        }
        if(Input.GetKey("2"))
        {
            set_player_item(2);
        }

        listen_item_pick_key_and_set();

    }

    void listen_item_pick_key_and_set(){

        if((item1_nottaken.transform.position - player.transform.position).magnitude < 2f)
        {
            //if player near to item1 more than 4f

            if(!check_player_have_item(1))
            {
                if(Input.GetKey("k")) //get item
                {
                    item1_nottaken.SetActive(false);
                    set_player_item(1);
                }

            }else{
                if(Input.GetKey("q")) //get item
                {
                    item1_nottaken.SetActive(true);
                    set_player_item(0);
                }
            }

        }
        if((item2_nottaken.transform.position - player.transform.position).magnitude < 2f)
        {
            //if player near to item1 more than 4f

            if(!check_player_have_item(2))
            {
                if(Input.GetKey("k")) //get item
                {
                    item2_nottaken.SetActive(false);
                    set_player_item(2);
                }

            }else{
                if(Input.GetKey("q")) //get item
                {
                    item2_nottaken.SetActive(true);
                    set_player_item(0);
                }
            }

        }

/*
        Debug.Log("run");

        if(!check_player_have_item(itemid))
        {
            //player have item
            if(Input.GetKey("k")) //get item
            {
                item1_nottaken.SetActive(false);
                set_player_item(itemid);

            }
        }else{
            //player have item
            if(Input.GetKey("q")) //drop item
            {
                item1_nottaken.SetActive(true);
                set_player_item(0); //reset player item

            }
        }
*/
    }

    void set_player_item(int itemid){

        switch (itemid)
        {
            case 0:
            {
                item1_env_view.SetActive(false);
                item1_onplayer.SetActive(false);
                item2_env_view.SetActive(false);
                item2_onplayer.SetActive(false);
                break;
            }
            case 1:
            {
                item1_env_view.SetActive(true);
                item1_onplayer.SetActive(true);
                item2_env_view.SetActive(false);
                item2_onplayer.SetActive(false);
                break;
            }
            case 2:
            {
                item1_env_view.SetActive(false);
                item1_onplayer.SetActive(false);
                item2_env_view.SetActive(true);
                item2_onplayer.SetActive(true);
                break;
            }


            default:
            return;
        }

    }

    bool check_player_have_item(int itemid){

        switch (itemid)
        {
            case 0:
            {
                if(!item1_env_view.active && !item2_env_view.active)
                {
                    return false;
                }
                return true;
            }

            case 1:
            {
                if(!item1_env_view.active)
                {
                    return false;
                }
                return true;
            }
            case 2:
            {
                if(!item2_env_view.active)
                {
                    return false;
                }
                return true;
            }


            default:
            return false;
        }

    }

}
