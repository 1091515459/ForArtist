#if UNITY_EDITOR
using System.Text;
using UnityEngine;
using UnityEditor;

namespace ABE
{
    static class AssetBundleExportQuick
    {
            private static AssetBundleExportHelper abeHelper = new AssetBundleExportHelper();
            // [MenuItem("Assets/打包模型(自动分类)")]
            // [MenuItem("GameObject/打包模型(自动分类)", priority = -1)]
            // public static void AssetsOut()
            // {
            //     UnityEngine.Object[] gameObjects = Selection.objects;
            //     foreach (var obj in gameObjects)
            //     {
            //         GameObject Gobj = obj as GameObject;
            //         if (Gobj.GetComponentsInChildren<LineRenderer>().Length > 0)
            //         {
            //             abeHelper.Out( Gobj.transform,EquipmentType.线);
            //         }
            //         else
            //         {
            //             abeHelper.Out( Gobj.transform,EquipmentType.点位);
            //         }
            //     }
            // }

            [MenuItem("GameObject/打包“线”模型", priority = -1)]
            public static void AssetsPointOut(MenuCommand menuCommand)
            {
                UnityEngine.Transform[] gameObjects = Selection.GetTransforms(SelectionMode.TopLevel);
                if (menuCommand.context != Selection.objects[0])return;
                foreach (var obj in gameObjects)
                {
                    abeHelper.Out(obj, EquipmentType.线);
                }
            }

            [MenuItem("GameObject/打包“点”模型", priority = -1)]
            public static void AssetsLineOut(MenuCommand menuCommand)
            {
                UnityEngine.Transform[] gameObjects = Selection.GetTransforms(SelectionMode.TopLevel);
                if (menuCommand.context != Selection.objects[0])return;
                foreach (var obj in gameObjects)
                {
                    abeHelper.Out(obj, EquipmentType.点位);
                }
            }
    }
}
#endif