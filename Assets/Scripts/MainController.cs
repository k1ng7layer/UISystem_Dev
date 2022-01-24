using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class MainController:MonoBehaviour
    {
        [SerializeField]
        MainLayerPresenter MainLayer;
        UIActionConfigurator ActionConfigurator { get; set; }
        void Fire()
        {
            Debug.Log("Fired!"); 
        }
        private void Awake()
        {
           
        }
        private void Start()
        {
        
        }
           
        public void Init()
        {
            ActionConfigurator = new UIActionConfigurator();
            ActionConfigurator.Configure();
            MainLayer.Init();
            ActionContainer.ResolveAction<ButtonClickAction>().AddListener(Fire);
        }
           
        private void OnDestroy()
        {
            ActionContainer.ResolveAction<ButtonClickAction>().RemoveListener(Fire);
        }
    }
}

           
            

       
           


