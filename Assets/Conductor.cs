using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    // audio
    public AudioHelm.HelmController helmController;
    public int note = 41;
    public float velocity = 0.95f;
    public int duration = 6;

    // visual
    public GameObject lightBeam;
    private VLB.VolumetricLightBeam beam;


    // Start is called before the first frame update
    void Start()
    {
        beam = lightBeam.GetComponent<VLB.VolumetricLightBeam>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!helmController.IsNoteOn(note))
        {
            helmController.NoteOn(note, velocity, duration);
        }       
        
        // helmController.SetParameterPercent(AudioHelm.Param.kFilterEnvelopeDepth, (Time.time * 0.3f)/100);

        beam.spotAngle = Time.time * 0.1f;
        beam.UpdateAfterManualPropertyChange();
    }
}
