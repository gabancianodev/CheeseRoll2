using System;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public static EventsManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region EVENTS DECLARATION
    public event Action OnPlayerJump;

    public event Action OnPlayerLanded;

    public event Action OnPlayerHit;

    public event Action OnPlayerDead;

    #endregion ---
    #region EVENTS INVOCATION

    public void InvokeOnPlayerJump()
    {
        OnPlayerJump.Invoke();
    }

    public void InvokeOnPlayerLanded()
    {
        OnPlayerJump.Invoke();
    }
    
    public void InvokeOnPlayerHit()
    {
        OnPlayerHit.Invoke();
    }

    public void InvokeOnPlayerDead(){
        OnPlayerDead.Invoke();
    }

    #endregion ---
}
