using Assets.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class WindowLayerPresenter : GUICollection<UIWindow>
    {
        public UIWindow ActiveWindow { get; set; }
        public override void Init()
        {
            base.Init();
            
            foreach (var window in registeredObjects.Values)
            {
                window.Init();
            }
            ActiveWindow = FindUI("pauseMenu");
            CommonActionsSet();
           
            
            
        }
        void OpenNewWindow(string id)
        {
            ActiveWindow.Close();
            ActiveWindow = FindUI(id);
            ActiveWindow.Open();
        }

        void CloseActiveWindow()
        {
            ActiveWindow.Close();
        }

        //События, применимые ко всем окнам интерфейса.
        void CommonActionsSet()
        {
            ActionContainer.ResolveAction<OpenWindowAction>().AddListener(OpenNewWindow);
            ActionContainer.ResolveAction<GamePauseAction>().AddListener(CloseActiveWindow);
        }


        
    }
        

}
       
        
        
            
       

                
             
            
            

          

                

      




