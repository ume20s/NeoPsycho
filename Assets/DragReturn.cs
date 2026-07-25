using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragReturn : MonoBehaviour
{
    private Vector3 startPosition;          // オブジェクトの元の位置
    private bool dragging = false;          // ドラッグフラグ
    public float returnSpeed = 8f;          // オブジェクトが戻る速さ

    // Start is called before the first frame update
    void Start()
    {
        // 最初の位置を保存
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if (dragging)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }
        else
        {
            transform.position = Vector3.Lerp(
                transform.position,
                startPosition,
                Time.deltaTime * returnSpeed);
        }
    }

    void OnMouseDown()
    {
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }
}
