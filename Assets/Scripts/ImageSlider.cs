using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageSlider : MonoBehaviour
{
    [Header("スライド設定")]
    public float slideDistance = 300f;      // スライドする距離（ピクセル）
    public float slideDuration = 2f;        // スライドにかかる時間（秒）
    public AnimationCurve slideCurve = AnimationCurve.EaseInOut(0, 0, 1, 1); // アニメーションカーブ

    [Header("開始設定")]
    public bool startOnAwake = true;        // 開始時に自動でスライドするか
    public bool slideFromLeft = true;       // 左からスライドするか（falseで右から）

    private RectTransform rectTransform;
    private Vector2 startPosition;
    private Vector2 targetPosition;
    private bool isSliding = false;

    void Start()
    {
        // RectTransformコンポーネントを取得
        rectTransform = GetComponent<RectTransform>();

        if (rectTransform == null)
        {
            Debug.LogError("ImageSliderはUI要素にアタッチしてください！");
            return;
        }

        // 開始位置と目標位置を設定
        SetupPositions();

        // 開始時にスライドする設定の場合
        if (startOnAwake)
        {
            StartSlide();
        }
    }

    /// <summary>
    /// 開始位置と目標位置を設定する
    /// </summary>
    void SetupPositions()
    {
        // 現在の位置を目標位置とする
        targetPosition = rectTransform.anchoredPosition;

        // 開始位置を計算（スライド方向に応じて）
        if (slideFromLeft)
        {
            startPosition = new Vector2(targetPosition.x - slideDistance, targetPosition.y);
        }
        else
        {
            startPosition = new Vector2(targetPosition.x + slideDistance, targetPosition.y);
        }

        // 開始位置に移動
        rectTransform.anchoredPosition = startPosition;
    }

    /// <summary>
    /// スライドアニメーションを開始する
    /// </summary>
    public void StartSlide()
    {
        if (isSliding) return;

        StartCoroutine(SlideCoroutine());
    }

    /// <summary>
    /// 逆方向にスライドする（元の位置に戻る）
    /// </summary>
    public void SlideBack()
    {
        if (isSliding) return;

        StartCoroutine(SlideBackCoroutine());
    }

    /// <summary>
    /// スライドアニメーションのコルーチン
    /// </summary>
    IEnumerator SlideCoroutine()
    {
        isSliding = true;
        float elapsedTime = 0f;

        while (elapsedTime < slideDuration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / slideDuration;

            // アニメーションカーブを適用
            float curveValue = slideCurve.Evaluate(progress);

            // 位置を補間
            Vector2 currentPosition = Vector2.Lerp(startPosition, targetPosition, curveValue);
            rectTransform.anchoredPosition = currentPosition;

            yield return null;
        }

        // 最終位置に確実に設定
        rectTransform.anchoredPosition = targetPosition;
        isSliding = false;

        // スライド完了時に呼び出されるイベント
        OnSlideComplete();
    }

    /// <summary>
    /// 逆スライドアニメーションのコルーチン
    /// </summary>
    IEnumerator SlideBackCoroutine()
    {
        isSliding = true;
        float elapsedTime = 0f;
        Vector2 currentStart = rectTransform.anchoredPosition;

        while (elapsedTime < slideDuration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / slideDuration;

            // アニメーションカーブを適用
            float curveValue = slideCurve.Evaluate(progress);

            // 位置を補間（逆方向）
            Vector2 currentPosition = Vector2.Lerp(currentStart, startPosition, curveValue);
            rectTransform.anchoredPosition = currentPosition;

            yield return null;
        }

        // 開始位置に確実に設定
        rectTransform.anchoredPosition = startPosition;
        isSliding = false;

        // 逆スライド完了時に呼び出されるイベント
        OnSlideBackComplete();
    }

    /// <summary>
    /// スライド完了時に呼び出される
    /// </summary>
    protected virtual void OnSlideComplete()
    {
        Debug.Log("スライド完了！");
        // ここに完了時の処理を追加できます
    }

    /// <summary>
    /// 逆スライド完了時に呼び出される
    /// </summary>
    protected virtual void OnSlideBackComplete()
    {
        Debug.Log("逆スライド完了！");
        // ここに完了時の処理を追加できます
    }

    /// <summary>
    /// スライド中かどうかを取得
    /// </summary>
    public bool IsSliding()
    {
        return isSliding;
    }

    /// <summary>
    /// スライドを即座に停止して目標位置に移動
    /// </summary>
    public void StopSlide()
    {
        StopAllCoroutines();
        rectTransform.anchoredPosition = targetPosition;
        isSliding = false;
    }
}