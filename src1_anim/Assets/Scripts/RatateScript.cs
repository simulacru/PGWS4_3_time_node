using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatateScript : MonoBehaviour
{
    [SerializeField] float rotateX = 0;
    [SerializeField] float rotateY = 0;
    [SerializeField] float rotateZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(new Vector3(rotateX * Time.deltaTime, rotateY * Time.deltaTime, rotateZ * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
