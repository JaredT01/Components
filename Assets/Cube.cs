using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
        private int timer = 0;
    private Vector3 position;
    private float Scale = 2;
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        position.x = 5f;
        position.y = 5f;
        position.z = 5f;
        rotation.x = 45f;
        rotation.y = 45f;
        rotation.z = 45f;
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
       gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z)* Scale;

        gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      gameObject.transform.position += new Vector3(0.01f, 0f, 0f);
    }
}
