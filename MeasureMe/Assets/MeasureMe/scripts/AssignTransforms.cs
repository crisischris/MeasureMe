using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignTransforms : MonoBehaviour
{

    public GameObject Den;
    public GameObject Beach;
    public GameObject Office;



    // Use this for initialization
    private void Start()
    {

        Debug.Log("should move spheres");

        Vector3 denVector = new Vector3(20, 200, 0);
        Vector3 beachVector = new Vector3(40, 200, 0);
        Vector3 officeVector = new Vector3(60, 200, 0);

        Den.transform.position = denVector;
        Beach.transform.position = beachVector;
        Office.transform.position = officeVector;

    }

}



