using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    //Конфигурация событий
    public class UIActionConfigurator
    {
        public void Configure()
        {
            ActionContainer.AddAction<ButtonClickAction>();
            ActionContainer.AddAction<OpenWindowAction>();
        }
    }
}
