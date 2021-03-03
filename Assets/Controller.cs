using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Light editorLighting;

    // Start is called before the first frame update
    void Start()
    {
        editorLighting = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        editorLighting.enabled = false;
    }
}
