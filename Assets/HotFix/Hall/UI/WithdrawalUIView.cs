using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Wanderer.GameFramework
{
    public class WithdrawalUIView : UGUIView
    {
        public Button btnClose;
        public override void OnInit(IUIContext uiContext)
        {
            base.OnInit(uiContext);

            btnClose.onClick.AddListener(() =>
            {
                GameMode.UI.Close(GameMode.UI.UIContextMgr["Assets/Addressable/Hall/Prefabs/UI/WithdrawalUIView.prefab"]);
            });
        }

        public override void OnFree(IUIContext uiContext)
        {
            base.OnFree(uiContext);
        }

        public override void OnEnter(IUIContext uiConext, Action<string> callBack = null, params object[] parameters)
        {
            base.OnEnter(uiConext, callBack, parameters);
            transform.Find("Panel").localScale = Vector3.zero;
            transform.Find("Panel").DOScale(new Vector3(1, 1, 1), .5f);
        }
    }
}
