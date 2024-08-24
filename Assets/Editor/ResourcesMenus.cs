using Sketches;
using UnityEditor;
using UnityEngine;

public static class ResourcesMenus
{
    [MenuItem("Assets/Loups/Set resource path", true)]
    static bool ValidateSetResourcePath()
    {
        // 检查是否选择了一个对象
        if (Selection.activeObject != null)
        {
            // 检查选中的对象是否挂载了 Sketcher 脚本
            GameObject selectedObject = Selection.activeObject as GameObject;
            if (selectedObject != null && selectedObject.GetComponent<Sketcher>() != null)
            {
                // 检查对象是否在 Resources 目录下
                string path = AssetDatabase.GetAssetPath(selectedObject);
                return path.StartsWith("Assets/Resources/");
            }
        }
        return false;
    }

    [MenuItem("Assets/Loups/Set resource path")]
    static void SetResourcePath()
    {
        GameObject selectedObject = Selection.activeObject as GameObject;
        if (selectedObject != null)
        {
            // 获取 Sketcher 组件
            Sketcher sketcher = selectedObject.GetComponent<Sketcher>();
            if (sketcher != null)
            {
                // 获取对象的资源路径
                string fullPath = AssetDatabase.GetAssetPath(selectedObject);
                string resourcePath = fullPath.Substring("Assets/Resources/".Length);
                resourcePath = resourcePath.Substring(0, resourcePath.LastIndexOf('.')); // 去掉扩展名

                // 设置 Sketcher 的 path
                sketcher.resourcePath = resourcePath;
                EditorUtility.SetDirty(sketcher); // 标记对象为已修改，确保保存更改

                Debug.Log("Sketcher.path set to: " + resourcePath);
            }
        }
    }
}