[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![Unity Engine](https://img.shields.io/badge/unity-2023.1.11f1-black.svg?style=flat&logo=unity)](https://unity3d.com/get-unity/download/archive)
[![Release](https://img.shields.io/github/tag/jcs090218/Unity.Prefs.svg?label=release&logo=github)](https://github.com/jcs090218/Unity.Prefs/releases/latest)
[![openupm](https://img.shields.io/npm/v/com.jcs090218.prefs?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.jcs090218.prefs/)
[![openupm](https://img.shields.io/badge/dynamic/json?color=brightgreen&label=downloads&query=%24.downloads&suffix=%2Fmonth&url=https%3A%2F%2Fpackage.openupm.com%2Fdownloads%2Fpoint%2Flast-month%2Fcom.jcs090218.prefs)](https://openupm.com/packages/com.jcs090218.prefs/)

# Prefs
> Retrieve list of EditorPrefs/PlayerPrefs

There isn't an easy way to retrieve key & value pair from EditorPrefs/PlayerPrefs.
This tiny library help you retrieve those data!

*P.S. See [EditorPrefs][] and [PlayerPrefs][] for more information!*

## 💾 Installation

`git clone` this repository, then throw the folder `Editor` to your project
under the `Assets` folder!

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

## License

Copyright (c) Jen-Chieh Shen. All rights reserved.

See [LICENSE](./LICENSE) for details.


[EditorPrefs]: https://docs.unity3d.com/ScriptReference/EditorPrefs.html
[PlayerPrefs]: https://docs.unity3d.com/ScriptReference/PlayerPrefs.html

[PlayerPrefsEditor]: https://github.com/sabresaurus/PlayerPrefsEditor
