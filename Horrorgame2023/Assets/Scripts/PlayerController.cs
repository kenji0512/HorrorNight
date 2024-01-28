using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Rigidbody を使ってプレイヤーを動かすコンポーネント
/// 入力を受け取り、それに従ってオブジェクトを動かす。
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    float h, v;
    /// <summary>動く速さ</summary>
    [SerializeField] float _movingSpeed = 5f;
    /// <summary>地面を表す Layer</summary>
    [SerializeField] LayerMask _groundLayer = 0;
    /// <summary>アイテムをゲットした時に鳴らす効果音</summary>
    [SerializeField] AudioClip _itemget = null;
    Rigidbody _rb = null;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 方向の入力を取得し、方向を求める
        float v = Input.GetAxisRaw("Vartical");
        float h = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        // 方向を取得
        Vector3 direction = transform.position + new Vector3(h, 0, v) * _movingSpeed;
        // directionの方向に向く
        transform.LookAt(direction);
        _rb.velocity = new Vector3(h, 0, v) * _movingSpeed;
    }
}
