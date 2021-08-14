using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters;

namespace UnityStandardAssets.Characters.FirstPerson
{
 

    public class CamSwitch : MonoBehaviour
    {        
        // Start is called before the first frame update
        void Start()
        {
            GetComponent<ExtendedFlycam>().enabled = false;
            GetComponent<FirstPersonController>().enabled = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey (KeyCode.C)) {
                if (GetComponent<ExtendedFlycam>().enabled) {
                    GetComponent<ExtendedFlycam>().enabled = false;
                    GetComponent<FirstPersonController>().enabled = true;
                } else {
                    GetComponent<ExtendedFlycam>().enabled = true;
                    GetComponent<FirstPersonController>().enabled = false;
                }
            }
        }
    }

}