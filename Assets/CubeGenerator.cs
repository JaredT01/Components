using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(cube);
    }

    // Update is called once per frame
    void Update()
    {

        GameObject cubeGenerated;
            cubeGenerated = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubeGenerated.AddComponent<Rigidbody>();
        Color color = Color.white;
        color.r = Random.Range(0.0f, 1.0f);
        cubeGenerated.GetComponent<MeshRenderer>().material.SetColor("_Color", Random.ColorHSV());
    }
}
