using Unity.Mathematics;
using UnityEngine;


    public class MovebleProdFactory: AbstractFactory
    {

      
        [SerializeField]private float _coldoun = 2f;
        private GameObject _productPrefab;
        private float _timer;

       

        private void Start()
        {
            _productPrefab = Resources.Load("V3_product") as GameObject;
            _timer = Time.time + _coldoun;
        }

        public override void GetProduct(Vector3 position)
        {
            GameObject curent = Instantiate(_productPrefab, position, quaternion.identity);
            IProduct c = curent.AddComponent<MovebleProduct>();
            c.init(curent);
        }

        private void Update()
        {
            if (Time.time > _timer)
            {
                GetProduct(transform.position);
                _timer += _coldoun;

            }
        }
    }
