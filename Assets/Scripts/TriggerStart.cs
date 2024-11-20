using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerStart : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public AudioSource triggerSound;
    public GameObject objectToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playableDirector.Play();

            if (triggerSound != null && !triggerSound.isPlaying)
            {
                triggerSound.Play();
            }

            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playableDirector.Pause();
        }
    }
}