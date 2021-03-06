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
using BridgeUI.Model;
namespace BridgeUI
{
    [System.Flags]
    public enum LoadType
    {
        DirectLink = 1,
        Resources = 1<<1,
        AssetBundle = 1<<2,
    }
}
