using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertNormals : MonoBehaviour {

    void Awake()
    {

    InvertSphere();
    }

    void InvertSphere()
    {
        Vector3[] normals = gameObject.GetComponent<MeshFilter>().mesh.normals;
        for(int i = 0; i < normals.Length; i++)
        {
            normals[i] = -normals[i];
        }
        gameObject.GetComponent<MeshFilter>().sharedMesh.normals = normals;

        int[] triangles = gameObject.GetComponent<MeshFilter>().mesh.triangles;

        for (int i = 0; i < triangles.Length; i+=3)
        {
            int t = triangles[i];
            triangles[i] = triangles[i + 2];
            triangles[i + 2] = t;

        }           

        gameObject.GetComponent<MeshFilter>().mesh.triangles= triangles;
    }
  
}
