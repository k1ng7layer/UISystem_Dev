using Assets.Interfaces;
using Assets.Scripts.Actions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class WindowLayerPresenter : GUICollection<UIWindow>
    {
        public UIWindow ActiveWindow { get; set; }
        public UIWindow DefaultWindow { get; set; }
        public override void Init()
        {
            base.Init();
            
            foreach (var window in registeredObjects.Values)
            {
                window.Init();
            }
            DefaultWindow = FindUI("pauseMenu");
            CommonActionsSet();
            ActiveWindow = registeredObjects.Values.FirstOrDefault(x => x.isVisibleOnStart == true);



        }
        void OpenNewWindow(string id)
        {
            ActiveWindow.Close();
            ActiveWindow = FindUI(id);
            ActiveWindow.Open();
        }

       

        void SwitchActiveWindow()
        {
            Debug.Log($"CloseActiveWindow");
            if (ActiveWindow == DefaultWindow)
            {
                ActiveWindow.Close();
                ActiveWindow = null;

            }
            else
            {
                DefaultWindow.Open();
                ActiveWindow = DefaultWindow;
            }

        }

        //События, применимые ко всем окнам интерфейса.
        void CommonActionsSet()
        {
            ActionContainer.ResolveAction<OpenWindowAction>().AddListener(OpenNewWindow);
            ActionContainer.ResolveAction<SwitchUIStateAction>().AddListener(SwitchActiveWindow);
        }

    }
        

}

        
       
        
        
            
       

                
             
            
            

          

                

      




