using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public event Action TimerExhausted;

    [SerializeField, Min(0f)] private float _time = 2f;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        _coroutine = StartCoroutine(TimerRoutine());
    }

    private void OnDisable()
    {
        _coroutine = null;
    }

    private IEnumerator TimerRoutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_time);
            TimerExhausted?.Invoke();
        }
    }
}
