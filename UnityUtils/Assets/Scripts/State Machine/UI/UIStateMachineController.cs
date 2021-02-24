﻿using UnityEngine;

public class UIStateMachineController : BaseStateMachine
{
    public static UIStateMachineController Instance;

    [Header("LoginPanel")]
    public LoginPanel LoginPanel;

    [Header("ServerSeletionPanel")]
    public ServerSelectionPanel ServerSelectionPanel;

    [HideInInspector]
    public string PlayerName;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ChangeTo<LoginState>();
    }
}
