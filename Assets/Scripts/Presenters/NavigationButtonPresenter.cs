using Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class NavigationButtonPresenter:ButtonPresenterBase,INavigationButton 
    {
        [SerializeField]
        string _id;
        public override string Id
        {
            get
            {
                return _id;
            }
        }

        [SerializeField]
        string _target;
        public string Target
        {
            get
            {
                return _target;
            }
        }



        //public event Action<NavigationButtonPresenter> OnClick;
        public override event Action<NavigationButtonPresenter> OnClick;

        public void Click()
        {
            Debug.Log("Click!");
            OnClick?.Invoke(this);
        }

        public void Close()
        {
            
        }

        public void Open()
        {
            
        }
    }
}
