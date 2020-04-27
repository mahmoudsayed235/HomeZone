using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDrag()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * -1, 0) * Time.deltaTime * speed, Space.World);
    }
}
