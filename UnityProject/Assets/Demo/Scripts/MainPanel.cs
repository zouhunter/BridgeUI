﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Sprites;
using UnityEngine.Scripting;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.Assertions.Must;
using UnityEngine.Assertions.Comparers;
using System.Collections;
using System.Collections.Generic;

public class MainPanel : GroupPanel {
    [SerializeField]
    private Button m_openPanel01;
    [SerializeField]
    private Button m_close;
    protected override void Awake()
    {
        base.Awake();
        m_openPanel01.onClick.AddListener(()=>selfFacade.Open(PanelNames.Panel01));
        m_close.onClick.AddListener(Close);
    }
}
