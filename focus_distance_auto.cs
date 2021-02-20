using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class focus_distance_auto : MonoBehaviour
{


    PostProcessVolume post_v;
    DepthOfField dof;



    // Start is called before the first frame update
    void Start()
    {   
        post_v = GetComponent<PostProcessVolume>();
        post_v.profile.TryGetSettings(out dof);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit intersection;
        

        if(Physics.Raycast(/*origin*/transform.position,/*distance*/transform.TransformDirection(Vector3.forward) /*<<-- same with Vector3.forward*/, out intersection)){
            //print(intersection.distance);
            dof.focusDistance.value = intersection.distance;

        }
    }



}
