using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public static class ActionContainer
    {
        private static Dictionary<Type, IGameAction> Actions = new Dictionary<Type, IGameAction>();

        public static void AddAction<SType>() where SType: IGameAction, new()
        {
            //var act = new IGameAction<string>();
            IGameAction type = new SType();
            Type actionType = typeof(SType);
            Actions.Add(actionType, type);
        }

        public static SType ResolveAction<SType>() where SType: IGameAction
        {
            Type actionType = typeof(SType);
            IGameAction result;
            if (Actions.TryGetValue(actionType, out result))
            {
                return (SType)result;
            }
            return default;
        }

        public static void ClearAllBinds()
        {
            Actions.Clear();
        }


    }
}
       






