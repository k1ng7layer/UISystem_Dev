using Assets.Interfaces;
using Assets.Scripts.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Presenters
{
    public class SceneNavigationButtonPresenter : ButtonPresenterBase
    {
        public string targetScene;
        public override void Click()
        {
            ActionContainer.ResolveAction<ChangeSceneAction>().Dispatch(targetScene);
        }
    }
}
