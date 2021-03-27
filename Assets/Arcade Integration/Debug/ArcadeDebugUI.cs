using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace debug
{
    public class ArcadeDebugUI : MonoBehaviour
    {
        ArcadeInput input;
        [SerializeField] Image R1, R2, R3, B1, B2, B3, start;
        [SerializeField] RectTransform stick;
        // Start is called before the first frame update
        void Start()
        {
            input = GetComponent<ArcadeInput>();
        }

        // Update is called once per frame
        void Update()
        {
            stick.localPosition = new Vector2(Input.GetAxisRaw(input.hori), Input.GetAxisRaw(input.verti)) * 40;

            if (Input.GetButtonDown(input.R1))
            {
                R1.color = Color.green;
            }else if (Input.GetButtonUp(input.R1))
            {
                R1.color = Color.white;
            }

            if (Input.GetButtonDown(input.R2))
            {
                R2.color = Color.green;
            }
            else if (Input.GetButtonUp(input.R2))
            {
                R2.color = Color.white;
            }

            if (Input.GetButtonDown(input.R3))
            {
                R3.color = Color.green;
            }
            else if (Input.GetButtonUp(input.R3))
            {
                R3.color = Color.white;
            }

            if (Input.GetButtonDown(input.B1))
            {
                B1.color = Color.green;
            }
            else if (Input.GetButtonUp(input.B1))
            {
                B1.color = Color.white;
            }

            if (Input.GetButtonDown(input.B2))
            {
                B2.color = Color.green;
            }
            else if (Input.GetButtonUp(input.B2))
            {
                B2.color = Color.white;
            }

            if (Input.GetButtonDown(input.B3))
            {
                B3.color = Color.green;
            }
            else if (Input.GetButtonUp(input.B3))
            {
                B3.color = Color.white;
            }

            if (Input.GetButtonDown(input.start))
            {
                start.color = Color.green;
            }
            else if (Input.GetButtonUp(input.start))
            {
                start.color = Color.white;
            }

            if (Input.GetButton("P1 Start") && Input.GetButton("P2 Start"))
            {
                print("exit");
                Application.Quit();
            }
        }
    }
}