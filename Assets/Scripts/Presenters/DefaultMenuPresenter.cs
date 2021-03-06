using Assets.Presenters;
using Assets.Scripts.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Presenters
{
    public class DefaultMenuPresenter : UIWindow
    {
        //Течение игрвого времени
        public float timeScale;
        public override void Init()
        {
            base.Init();

            foreach (var btn in registeredObjects.Values)
            {
                if (btn.GetType().Equals(typeof(NavigationButtonPresenter)))
                {
                    btn.OnClick += NavigationButtonClicked;
                }

            }
            if (!isVisibleOnStart)
                Close();
        }
        public override void Open()
        {
            base.Open();
            ActionContainer.ResolveAction<UIOpenAction>().Dispatch(timeScale);
        }
        public override void ActionButtonClicked(ActionButtonPresenter action)
        {

        }

        public override void NavigationButtonClicked(NavigationButtonPresenter button)
        {
            ActionContainer.ResolveAction<OpenWindowAction>().Dispatch(button.Target);
        }
    }
}
