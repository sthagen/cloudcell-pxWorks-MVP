/////////////////////////////////////////
//     THIS IS AUTOGENERATED CODE      //
//       do not change directly        //
/////////////////////////////////////////
using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using CometUI;

namespace MainScene_UI
{
    partial class FileItem : BaseView //Autogenerated
    {
        /// <summary>Static instance of the view</summary>
        public static FileItem Instance { get; private set; }
        // Controls
        #pragma warning disable 0414
        //[Header("Controls (auto capture)")]
        [Header("Custom")]
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button bt = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Image icon = default;
        [AutoGenerated, SerializeField, HideInInspector] TMPro.TextMeshProUGUI text = default;
        #pragma warning restore 0414
        
        public override void AutoSubscribe()
        {
            SubscribeOnChanged(bt);
            SubscribeOnChanged(icon);
            SubscribeOnChanged(text);
        }
        ///<summary>Data</summary>
        public string dir{ get; private set; }
        public int level{ get; private set; }
        
        [VisibleInGraph(false)]
        public void Build(string dir, int level)
        {
            this.dir = dir;
            this.level = level;
            OnBuildSafe(true);
        }
        
        public override BaseView Clone()
        {
            var clone = (FileItem)base.Clone();
            clone.dir = dir;
            clone.level = level;
            return clone;
        }
    }
}