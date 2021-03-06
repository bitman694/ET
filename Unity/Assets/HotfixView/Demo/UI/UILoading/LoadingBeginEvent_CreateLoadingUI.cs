﻿using UnityEngine;

namespace ET
{
    [Event()]
    public class LoadingBeginEvent_CreateLoadingUI : AEvent<EventType.LoadingBegin>
    {
        public override void Run(EventType.LoadingBegin args)
        {
            UI ui = UILoadingFactory.Create(args.Scene);
			Game.Scene.GetComponent<UIComponent>().Add(ui);
        }
    }
}
