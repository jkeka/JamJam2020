using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator doorAnim;

    [Header("Animation Names")]
    [SerializeField] private string openAnimationName = "Kaappi_open";

    public Transform player;

    bool open = false;

    private void Awake()
    {
        doorAnim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist < 2 && !open)
        {
            doorAnim.Play(openAnimationName, 0, 0.0f);
            open = true;
        }
    }
}
