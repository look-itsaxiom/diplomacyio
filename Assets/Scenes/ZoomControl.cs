using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomControl : MonoBehaviour
{
    public CinemachineVirtualCamera cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && cam.m_Lens.OrthographicSize > 5)
        {
            cam.m_Lens.OrthographicSize--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && cam.m_Lens.OrthographicSize < 30)
        {
            cam.m_Lens.OrthographicSize++;
        }
    }
}
