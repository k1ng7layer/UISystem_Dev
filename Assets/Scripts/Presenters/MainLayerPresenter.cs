using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class MainLayerPresenter : MonoBehaviour
    {
        [SerializeField]
        public WindowLayerPresenter windows;
        public void Init()
        {
            windows = GetComponentInChildren<WindowLayerPresenter>();
            windows.Init();
        }
            

    }
}

