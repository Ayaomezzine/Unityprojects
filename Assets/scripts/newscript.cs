using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscript : MonoBehaviour
{
    public Transform earth;
    public Transform moon;
    public Transform mars;

    public float earthRotationSpeed = 10f;
    public float moonRotationSpeed = 20f;
    public float marsRotationSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the Earth around its own axis
        earth.Rotate(Vector3.up, earthRotationSpeed * Time.deltaTime);

        // Rotate the Moon around the Earth
        moon.RotateAround(earth.position, Vector3.up, moonRotationSpeed * Time.deltaTime);

        // Rotate the Mars around the Moon
        mars.RotateAround(moon.position, Vector3.up, marsRotationSpeed * Time.deltaTime);
    }
}
