using UnityEngine;
using UnityEditor;

public class CheckForDontSaveAssets : EditorWindow
{
    [MenuItem("Tools/Check DontSave Assets")]
    public static void FindDontSaveAssets()
    {
        Object[] allAssets = Resources.FindObjectsOfTypeAll(typeof(Object));
        foreach (Object asset in allAssets)
        {
            if (asset.hideFlags.HasFlag(HideFlags.DontSave))
            {
                Debug.LogWarning("DontSave Asset: " + asset.name + " (" + asset.GetType().Name + ")");
            }
        }
    }
}
