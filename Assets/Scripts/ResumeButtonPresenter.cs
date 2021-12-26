using Assets.Presenters;
using Assets.Scripts.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class ResumeButtonPresenter:ActionButtonPresenter
    {
        public override void Click()
        {
            base.Click();
            ActionContainer.ResolveAction<SwitchUIStateAction>().Dispatch();
        }
    }
}
