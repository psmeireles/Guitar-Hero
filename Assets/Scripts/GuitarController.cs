using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _chords;

    private const KeyCode
        L2 = KeyCode.JoystickButton6,
        L1 = KeyCode.JoystickButton4,
        R1 = KeyCode.JoystickButton5,
        R2 = KeyCode.JoystickButton7,
        X = KeyCode.JoystickButton1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var chord in _chords)
            chord.GetComponent<Renderer>().material.color = Color.white;

        if (Input.GetKey(L2))
            _chords[0].GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKey(L1))
            _chords[1].GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKey(R1))
            _chords[2].GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKey(R2))
            _chords[3].GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKey(X))
            _chords[4].GetComponent<Renderer>().material.color = Color.red;

    }
}
