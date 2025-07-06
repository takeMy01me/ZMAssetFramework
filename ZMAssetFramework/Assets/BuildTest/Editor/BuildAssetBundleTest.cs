using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildAssetBundleTest
{
    public static string BundleOutPutPath { get { return Application.dataPath + "/../AssetBundle/"; } } //  Application.dataPath =>  | .. => 返回前一个路径的上一级

    [MenuItem("ZMFrame/BuildAssetBundle")]
    public static void BuildAssetBundle()
    {
        if (!Directory.Exists(BundleOutPutPath))
        {
            Directory.CreateDirectory(BundleOutPutPath);
        }

        BuildPipeline.BuildAssetBundles(BundleOutPutPath, BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
    }
}
