using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
public class UiManager : MonoBehaviour
{
    [SerializeField]
    CinemachineDollyCart cinemachineDolly;
    [SerializeField]
    GameObject StartCanva;
    void Start()
    {
        //cinemachineDolly = GetComponent<CinemachineDollyCart>();
    }

    
    void LateUpdate()
    {
       
        if (cinemachineDolly.m_Position > 120f)
            StartCanva.SetActive(true);

    }


}
