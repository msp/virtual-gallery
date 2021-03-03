using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

   void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.down, 20 * Time.deltaTime);
    }



}
