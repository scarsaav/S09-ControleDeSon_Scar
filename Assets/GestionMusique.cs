using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionMusique : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;


    public void ChangerVolumeMusique(float nouveauVolume) //connection au script 
    {
        Debug.Log("Changer volume musique" + nouveauVolume);
        _mixer.SetFloat("VolumeMusique", nouveauVolume);
    }
}
