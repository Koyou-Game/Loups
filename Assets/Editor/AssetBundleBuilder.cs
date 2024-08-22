using System.IO;
using Koyou.Commons;
using UnityEditor;

public static class AssetBundleBuilder
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        // 设置目标路径
        string assetBundleDirectory = "Assets/BuildAssetBundles";

        // 检查目录是否存在，如果不存在则创建
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
            Log.N($"Created directory: " + assetBundleDirectory);
        }

        // 构建 AssetBundles
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

        Log.N($"AssetBundles built successfully!");
    }
}