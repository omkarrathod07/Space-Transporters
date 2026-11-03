using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundThemeManager : MonoBehaviour
{
    [SerializeField] private List<Sprite> backgroundlist;
    private SpriteRenderer backgroundRenderer;
    private int min = 1;
    private int max;
    private void Awake()
    {
        max = backgroundlist.Count;
        int random = Random.Range(min, max);
        backgroundRenderer = GetComponent<SpriteRenderer>();
        backgroundRenderer.sprite = backgroundlist[random];
        backgroundRenderer.gameObject.SetActive(true);
    }
}
