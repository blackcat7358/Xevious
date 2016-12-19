using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour
{
    public static int wave;
    public static int seisei = 0;
    public GameObject[] Waves;

    void Update()
    {
        if (wave == 0 && seisei == 0)
        {
            Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei++;
        }
        if (wave == 1 && seisei == 1)
        {
            Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei++;
        }

        if (wave == 2 && seisei == 2)
        {
            Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei++;
        }
        if (wave == 3 && seisei == 3)
        {
            Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei++;
        }
        if (wave == 4 && seisei == 4)
        {
            Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei++;
        }
        if (wave == 5 && seisei == 5)
        {
            Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei++;
        }
        if (wave == 6 && seisei == 6)
        {
            //Instantiate(Waves[wave], transform.position, transform.rotation);
            seisei = 0;
            wave = 0;
        }
    }


}
    /*public GameObject[] waves;  // Waveプレハブを格納する
    private int currentWave;        // 現在のWave

    IEnumerator Start()
    {
        // Waveが存在しなければコルーチンを終了する
        if (waves.Length == 0)
        {
            yield break;//
        }
        while (true)
        {
            GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity); // Waveを作成
            wave.transform.parent = transform;          // WaveをEmitterの子要素にする
                                                        // Waveの子要素のEnemyが全て削除されるまで待機する
            while (wave.transform.childCount != 0)
            {
                yield return new WaitForEndOfFrame();
            }
            Destroy(wave);          // Waveの削除
                                    // 格納されているWaveを全て実行したらcurrentWaveを0にする（最初から -> ループ）
            if (waves.Length <= ++currentWave)
            {
                currentWave = 0;
            }
        }
    }*/

