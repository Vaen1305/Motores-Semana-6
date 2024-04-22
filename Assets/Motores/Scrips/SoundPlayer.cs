using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private SoundD _enterSoundClip; 
    [SerializeField] private AudioSource _audioSource; 

    private void OnTriggerEnter(Collider other)
    {
        if (_audioSource != null && _enterSoundClip != null && _enterSoundClip.SoundClip != null)
        {
            _audioSource.clip = _enterSoundClip.SoundClip;
            _audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_audioSource != null && _enterSoundClip != null && _enterSoundClip.SoundClip != null)
        {
            _audioSource.clip = _enterSoundClip.SoundClip;
            _audioSource.Play();
        }
    }
}
