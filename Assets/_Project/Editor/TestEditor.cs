using UnityEditor;
using UnityEngine;
using Prefs;

public class TestEditor : EditorWindow
{

    [MenuItem("Tools/Prefs/Window/Test", false, -1000)]
    public static void ShowWindow()
    {
        EditorWindow window = GetWindow<TestEditor>("Mx Completion");
        window.Show();
    }

    private void OnEnable()
    {
        const Prefs.PrefType type = Prefs.PrefType.Editor;  // Or .Player for `PlayerPrefs`

        PrefPair[] prefs = Prefs.Prefs.GetPrefs(type);

        foreach (PrefPair pair in prefs)
        {
            Debug.Log(pair.Key + " : " + pair.Value);
        }
    }
}
