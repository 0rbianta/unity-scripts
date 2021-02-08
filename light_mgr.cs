using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class light_mgr : MonoBehaviour
{

    public int sleep_seconds = 1;
    private bool is_light1_controllable = true;
    public GameObject player, light1, ligth1_on, ligth1_off;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(is_light1_controllable)
        {
            if((ligth1_on.transform.position - player.transform.position).magnitude < 2f)
            {
                //player near to light more than 2f
                if(Input.GetKey("k")) //Open/close light
                {
                    light_activity(light1, ligth1_on, ligth1_off);
                    is_light1_controllable=false;
                    StartCoroutine(light_controllable_changer());
                }
            }
        }
        
    }

    void light_activity(GameObject light, GameObject light_on, GameObject light_off){

        if(!light.active)
        {
            light_on.SetActive(true);
            light_off.SetActive(false);
            light.SetActive(true);
        }else{
            light_on.SetActive(false);
            light_off.SetActive(true);
            light.SetActive(false);
        }

    }

    IEnumerator light_controllable_changer(){
        yield return new WaitForSeconds(sleep_seconds);
        is_light1_controllable=true;
    }



}
