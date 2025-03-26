using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSonGeneral : MonoBehaviour
{
    [SerializeField] private GameObject _menuAudio;
    
    void OnMenu()
    {
        _menuAudio.SetActive(true);
    }
}
