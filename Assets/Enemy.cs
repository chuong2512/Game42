using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Duration = 8;

    // Start is called before the first frame update
    void OnEnable()
    {
        transform.DOMove(transform.position + Vector3.left * 30, Duration).SetEase(Ease.Linear).OnComplete(() =>
        {
            Destroy(gameObject);
        });
    }

    // Update is called once per frame
    void Update()
    {
    }
}