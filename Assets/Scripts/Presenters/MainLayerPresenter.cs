using Assets.Scripts.Presenters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class MainLayerPresenter : MonoBehaviour
    {
        [SerializeField]
        public WindowLayerPresenter windows;
        [SerializeField]
        public PanelLayerPresenter panels;
        public string Id;
        public void Init()
        {
            windows = GetComponentInChildren<WindowLayerPresenter>();
            panels = GetComponentInChildren<PanelLayerPresenter>();
            windows.Init();
            panels.Init();
        }
    }
            

}

