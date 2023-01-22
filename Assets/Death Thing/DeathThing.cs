using System;
using DG.Tweening;
using Platformer.Mechanics;
using UnityEngine;

public class DeathThing : MonoBehaviour
{
    public static DeathThing instance;

    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    public Transform player;
    public RectTransform thing;
    public float maxSize = 1000;
    public float firstSize = 40;
    public float firstDuration = 0.5f;
    public float delay = 0.5f;
    public float secondDuration = 0.2f;
    public float resetDuration = 0.5f;

    private Vector3 lastPos;


    public void Update()
    {
        var point = Camera.main.WorldToScreenPoint(lastPos);
        thing.position = point;
    }


    public void Trigger(PlayerController player)
    {
        gameObject.SetActive(true);
        lastPos = player.transform.position;
        thing.DOSizeDelta(new Vector2(firstSize, firstSize), firstDuration).SetUpdate(true);
        thing.DOSizeDelta(Vector2.zero, secondDuration).SetDelay(firstDuration + delay).SetUpdate(true);
    }

    public void ResetThing(PlayerController player)
    {
        lastPos = player.GetComponent<Rigidbody2D>().position;
        thing.DOSizeDelta(new Vector2(maxSize, maxSize), resetDuration).SetDelay(0.1f).SetUpdate(true).onComplete +=
            () => gameObject.SetActive(false);
    }
}