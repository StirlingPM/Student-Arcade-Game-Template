using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputTest : MonoBehaviour
{
    // Update is called once per frame
    ArcadeInput input;

    private void Awake()
    {
        input = GetComponent<ArcadeInput>();
    }
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw(input.hori), 0, Input.GetAxisRaw(input.verti)) * Time.deltaTime);
        if (Input.GetButtonDown(input.B1))
        {
            print("B1");
        }
    }
}

