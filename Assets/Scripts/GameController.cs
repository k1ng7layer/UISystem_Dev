using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameController:MonoBehaviour
    {
        MainController UIController;
        //StateController State { get; set; }
        private void Awake()
        {
            UIController = FindObjectOfType<MainController>();
            //State = new StateController();
        }
        private void Start()
        {
            
            UIController.Init();
            //State.Init();
        }
    }
}

        
