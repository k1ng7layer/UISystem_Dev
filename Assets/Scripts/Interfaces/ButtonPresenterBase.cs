using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Interfaces
{
    public abstract class ButtonPresenterBase:MonoBehaviour, IDisplayable
    {
        [SerializeField]
        string _id;
        public virtual string Id
        {
            get
            {
                return _id;
            }
        }
        public abstract event Action<NavigationButtonPresenter> OnClick;


        public void Close()
        {
            
        }

        public void Open()
        {
            
        }
    }
}
