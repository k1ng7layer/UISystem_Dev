using Assets.Scripts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Presenters
{
    public class PanelLayerPresenter:GUICollection<UIActionBar>
    {
        public override void Init()
        {
            base.Init();

            foreach (var window in registeredObjects.Values)
            {
                window.Init();
            }

        }

    }
}



            
