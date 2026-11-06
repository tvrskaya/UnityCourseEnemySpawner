using System.Linq;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Spawner[] _spawners;

    private void OnEnable()
    {
        _timer.TimerExhausted += ProcessTimerExhausted;
    }

    private void OnDisable()
    {
        _timer.TimerExhausted -= ProcessTimerExhausted;
    }

    private void ProcessTimerExhausted()
    {
        if (_spawners.Length > 0)
        {   
            var timerIndex = Random.Range(0, _spawners.Length);
            _spawners[timerIndex].Spawn();
        }
    }
}
