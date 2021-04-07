using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class focus_distance_auto : MonoBehaviour
{

    GameObject[] invisible_objs;
    PostProcessVolume post_v;
    DepthOfField dof;
    public GameObject cam;
    string inv_tag_name = "invisible";


    // Start is called before the first frame update
    void Start()
    {   
        post_v = cam.GetComponent<PostProcessVolume>();
        post_v.profile.TryGetSettings(out dof);

        invisible_objs = GameObject.FindGameObjectsWithTag(inv_tag_name);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit intersection;
        

        if(Physics.Raycast(/*origin*/transform.position,/*distance*/transform.TransformDirection(Vector3.forward) /*<<-- same with Vector3.forward*/, out intersection)){
            //print(intersection.distance);

            for(int i=0;i<invisible_objs.Length;i++){
                if (!((transform.TransformDirection(Vector3.forward).z - invisible_objs[i].transform.TransformDirection(Vector3.forward).z) < 4f)){

                
                    dof.focusDistance.value = intersection.distance;
                }
            }


        }
    }



}
