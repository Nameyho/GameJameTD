using UnityEngine;

public class Bullet : MonoBehaviour
{

    #region private
    private Transform _transform;
    private Rigidbody _Rigidbody;

    [SerializeField]
    private float _bulletSpeed;

    private Bullet _bullet;

    private float _damage;
    public float damage{
        get => _damage;
        set => _damage = value;
    }



    #endregion



    #region  Unity APi
    private void Awake()
    {

        _transform = transform;
        _Rigidbody = GetComponent<Rigidbody>();
        _bullet = GetComponent<Bullet>();

    }

    private void FixedUpdate()
    {

        Vector3 velocity = transform.forward * _bulletSpeed;
        Vector3 movementStep = velocity * Time.fixedDeltaTime;
        Vector3 NewPos = _transform.position + movementStep;
        _Rigidbody.MovePosition(NewPos);

    }
    public void Shoot(float speed)
    {
        _bulletSpeed = speed;

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }




    #endregion
}

