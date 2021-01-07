using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //groudのゲームオブジェクトを入れる・
    private GameObject ground;
    //UnityChan2Dのゲームオブジェクトを入れる・
    private GameObject UnityChan2D;
    //キューブの移動速度
    private float speed = -12f;
    //消滅位置
    private float deadLine = -10f;
    // Start is called before the first frame update
    void Start()
    {
        //groundを取得
        ground = GameObject.Find("ground");
        //UnityChan2Dを取得
        UnityChan2D = GameObject.Find("UnityChan2D");

    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
    //オブジェクトが当たった時に音を呼び出す・
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CubePrefabTag"||collision.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
