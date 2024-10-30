using System;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioClip _Start;
    [SerializeField] private AudioClip _Loop;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = _Loop;
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }
}
