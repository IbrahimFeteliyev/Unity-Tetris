using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip lineClear;
    [SerializeField] private AudioClip lineInstantDown;
    [SerializeField] private AudioClip lineRotate;

    [Range(0.0f, 1.0f)]
    public float lineClearVolume = 1.0f;

    [Range(0.0f, 1.0f)]
    public float lineInstantDownVolume = 1.0f;

    [Range(0.0f, 1.0f)]
    public float lineRotateVolume = 1.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LineClear()
    {
        audioSource.volume = lineClearVolume;
        audioSource.PlayOneShot(lineClear);
    }

    public void LineInstantDown()
    {
        audioSource.volume = lineInstantDownVolume;
        audioSource.PlayOneShot(lineInstantDown);
    }

    public void LineRotate()
    {
        audioSource.volume = lineRotateVolume;
        audioSource.PlayOneShot(lineRotate);
    }
}
