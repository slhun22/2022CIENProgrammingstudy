using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundoutput : MonoBehaviour
{
    [SerializeField]
    private AudioSource _effectSound;
    [SerializeField]
     private AudioClip _testOutput;


    private void Awake()
    {
        _effectSound = gameObject.GetComponent<AudioSource>(); 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Muyaho_Villian")
        {
            _effectSound.PlayOneShot(_testOutput);
        }
    }


}
