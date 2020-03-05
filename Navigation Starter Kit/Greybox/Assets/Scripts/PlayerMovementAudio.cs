using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerMovementAudio : MonoBehaviour
{
    AudioSource audioSource;
    public List<AudioClip> possibleClips;


    public void Start()
    {     
        audioSource = GetComponent<audioSource>();
        GetComponent<PlayerMovementRayCast>().RayCastReady += PlayerNavMover_RayCastReady;
    }

    private void PlayerNavMover_RayCastReady(RaycastHit selectionData)
    {
        if (possibleClips.Count < 0)
        {
            //pick random audio
            int index = Random.Range(0, possibleClips.Count - 1);
            audioSource.clip = possibleClips[index];

            if (audioSource.isPlaying)
                audioSource.Play();
        }     
    }
}
