namespace Tilia.CameraRigs.UnityXR.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "CameraRigs/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.camerarigs.unityxr";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsUnityXR = "CameraRigs.UnityXR";

        [MenuItem(menuItemRoot + prefabCameraRigsUnityXR, false, priority)]
        private static void AddCameraRigsUnityXR()
        {
            string prefab = prefabCameraRigsUnityXR + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}