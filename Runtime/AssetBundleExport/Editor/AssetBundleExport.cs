#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ABE;
using UnityEditor;
using UnityEngine;

namespace ABE
{
    [CustomEditor(typeof(AssetBundleExportModel), true)]
    [CanEditMultipleObjects]
    public class AssetBundleExport : Editor
    {
        private AssetBundleExportModel abeModel { get { return serializedObject.targetObject as AssetBundleExportModel; } }
        private AssetBundleExportHelper abeHelper = new AssetBundleExportHelper();
        private Object t = null;
        private Object ts = null;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            t = EditorGUILayout.ObjectField("obj", t, typeof(Transform), true);
            if (GUILayout.Button("Out"))
            {
                if (t != null)
                    abeHelper.Out(t as Transform, abeModel.type);
            }
        }


    }
    
}

#endif
