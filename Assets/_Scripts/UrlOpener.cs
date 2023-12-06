using UnityEngine;
using System.Collections;

public class UrlOpener : MonoBehaviour
{
    public string Url;

    public void Open() {
        Application.OpenURL(Url);
    }
}
