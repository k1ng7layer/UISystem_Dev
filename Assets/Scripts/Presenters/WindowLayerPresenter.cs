using Assets.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class WindowLayerPresenter : GUICollection<UIWindow>
    {
        

        [SerializeField]
        PauseMenuWindow PauseMenu { get; set; }
        
        public UIWindow ActiveWindow { get; set; }
        
        
       

        public override void Init()
        {
            base.Init();
            var windows = base.GetAllObjects();
            foreach (var window in windows)
            {
                window.Init();
                var buttons = window.GetAllObjects();
            }
             
            PauseMenu = GetComponentInChildren<PauseMenuWindow>();
            PauseMenu.Init();
            ActionContainer.ResolveAction<OpenWindowAction>().AddListener(SetActiveWindow);
            ActionContainer.ResolveAction<OpenWindowAction>().AddListener(OpenNewWindow);

            ActiveWindow = FindUI("pauseMenu");
        }
          

                

        public void SetActiveWindow(string id)
        {

            ActiveWindow.Close();
            ActiveWindow = FindUI(id);
            Debug.Log($"active window changed! now = {ActiveWindow}");
        }

        void OpenNewWindow(string id)
        {
            Debug.Log($"closing active window = {ActiveWindow}");
            ActiveWindow.Close();
            FindUI(id).Open();
        }


    }
}

