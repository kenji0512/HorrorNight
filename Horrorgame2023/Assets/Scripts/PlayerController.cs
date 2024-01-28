using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Rigidbody ���g���ăv���C���[�𓮂����R���|�[�l���g
/// ���͂��󂯎��A����ɏ]���ăI�u�W�F�N�g�𓮂����B
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    float h, v;
    /// <summary>��������</summary>
    [SerializeField] float _movingSpeed = 5f;
    /// <summary>�n�ʂ�\�� Layer</summary>
    [SerializeField] LayerMask _groundLayer = 0;
    /// <summary>�A�C�e�����Q�b�g�������ɖ炷���ʉ�</summary>
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
        // �����̓��͂��擾���A���������߂�
        float v = Input.GetAxisRaw("Vartical");
        float h = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        // �������擾
        Vector3 direction = transform.position + new Vector3(h, 0, v) * _movingSpeed;
        // direction�̕����Ɍ���
        transform.LookAt(direction);
        _rb.velocity = new Vector3(h, 0, v) * _movingSpeed;
    }
}
