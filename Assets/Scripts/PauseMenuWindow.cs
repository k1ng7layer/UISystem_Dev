using Assets.Presenters;
using Assets.Scripts.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class PauseMenuWindow : DefaultMenuPresenter
    {
       


        

        public override void ActionButtonClicked(ActionButtonPresenter action)
        {
            ActionContainer.ResolveAction<ButtonClickAction>().Dispatch();
        }

        public override void NavigationButtonClicked(NavigationButtonPresenter buttonPresenter)
        {
            Debug.Log("Clicccked");
            ActionContainer.ResolveAction<OpenWindowAction>().Dispatch(buttonPresenter.Target);
        }
            
        public override void Init()
        {
            base.Init();
            var buttons = base.GetAllObjects();
            foreach (var btn in buttons)
            {
                btn.OnClick += NavigationButtonClicked;
            }
            
        }

     
    }
}
           
            


