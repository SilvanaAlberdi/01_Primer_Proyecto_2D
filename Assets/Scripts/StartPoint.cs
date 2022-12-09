using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public string uuid; // uuid = universal unique identifier

    private PlayerController player;
    [SerializeField] private Vector2 facingDirection;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        if (!player.nextUuid.Equals(uuid))
        {
            return;
        }
        player.transform.position = transform.position;
        player.lastDirection = facingDirection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
