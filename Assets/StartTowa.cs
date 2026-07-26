using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class StartTowa : MonoBehaviour
{
    [SerializeField] private Image fadeImage;           // 真っ黒イメージ
    [SerializeField] private float fadeDuration = 2.0f; // フェード時間

    private bool isTransitioning = false;

    private void OnMouseDown()
    {
        if (isTransitioning) return; // 連打防止
        isTransitioning = true;

        // 1秒かけてAlphaを1（真っ黒）にし、完了したらシーン遷移
        fadeImage.DOFade(1.0f, fadeDuration).OnComplete(() => SceneManager.LoadScene("TowaScene"));
    }
}
