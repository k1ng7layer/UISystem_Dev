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
        [SerializeField]
        internal bool isVisibleOnStart;
        [SerializeField]
        string _id;
        public string Id
        {
            get
            {
                return _id;
            }
        }

        public abstract void NavigationButtonClicked(NavigationButtonPresenter button);
        public abstract void ActionButtonClicked(ActionButtonPresenter action);

        public virtual void Close()
        {
            this.gameObject.SetActive(false);
        }

        public virtual void Open()
        {
            this.gameObject.SetActive(true);
        }

       
    }
}
