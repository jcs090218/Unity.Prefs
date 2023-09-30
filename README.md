[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![Unity Engine](https://img.shields.io/badge/unity-2023.1.11f1-black.svg?style=flat&logo=unity)](https://unity3d.com/get-unity/download/archive)
[![Release](https://img.shields.io/github/tag/jcs090218/Unity.Prefs.svg?label=release&logo=github)](https://github.com/jcs090218/Unity.Prefs/releases/latest)

# Unity.Prefs
> Retrieve ist of EditorPrefs/PlayerPrefs

## 🔨 Usage

```cs
const Prefs.PrefType type = Prefs.PrefType.Editor;  // Or .Player for `PlayerPrefs`

PrefPair[] prefs = Prefs.Prefs.GetPrefs(type);

foreach (PrefPair pair in prefs)
{
    Debug.Log(pair.Key + " : " + pair.Value);
}
```

## 📌 Credits

- [PlayerPrefsEditor][] by **`@sabresaurus`** - Retrieved list of `EditorPrefs`/`PlayerPrefs`


[PlayerPrefsEditor]: https://github.com/sabresaurus/PlayerPrefsEditor
