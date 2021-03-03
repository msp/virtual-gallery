using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject target;
    private VLB.VolumetricLightBeam beam;

    // Start is called before the first frame update
    void Start()
    {
        beam = GetComponent<VLB.VolumetricLightBeam>();
    }

   void Update()
    {
        // transform.RotateAround(target.transform.position, Vector3.down, 20 * Time.deltaTime);
        // beam.fallOffEnd = Time.time * 0.1f;
        // beam.color = Color.red;
        beam.spotAngle = Time.time * 0.3f;
        beam.UpdateAfterManualPropertyChange(); // take the changes into account
    }



}
