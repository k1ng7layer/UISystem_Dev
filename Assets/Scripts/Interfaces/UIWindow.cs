using Assets.Interfaces;
using Assets.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class UIWindow:GUICollection<ButtonPresenterBase>,IDisplayable
    {
        public abstract string Id { get; }

        public abstract void NavigationButtonClicked(NavigationButtonPresenter button);
        public abstract void ActionButtonClicked(ActionButtonPresenter action);

        public void Close()
        {
            this.gameObject.SetActive(false);
        }

        public void Open()
        {
            this.gameObject.SetActive(true);
        }

       
    }
}
