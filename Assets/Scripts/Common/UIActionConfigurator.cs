using Assets.Scripts.Actions;
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
            ActionContainer.AddAction<GamePauseAction>();
            ActionContainer.AddAction<ApplySettingsAction>();
            ActionContainer.AddAction<BackToMainAction>();
            ActionContainer.AddAction<InputPauseAction>();
            ActionContainer.AddAction<ChangeSceneAction>();
            ActionContainer.AddAction<UIOpenAction>();
            ActionContainer.AddAction<UICloseAction>();
            ActionContainer.AddAction<SwitchUIStateAction>();
        }
    }
}
