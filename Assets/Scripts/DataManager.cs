using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour, IManager
{
    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        _state = "DataManager be starting up, ma dude";
        Debug.Log(_state);
    }
}
