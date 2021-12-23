using Assets.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class OptionsMenuWindow : UIWindow
    {
        public override string Id
        {
            get
            {
                return "optionsMenu";
            }
        }
        public override void Init()
        {
            base.Init();
            var buttons = base.GetAllObjects();
            foreach (var btn in buttons)
            {
                btn.OnClick += NavigationButtonClicked;
            }
            Close();

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
