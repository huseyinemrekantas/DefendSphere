using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateManager : MonoBehaviour
{
    //Player Create
    public GameObject playerGameObject;
    //Oluştuurulmasını istediğimiz objeler.
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject key;
    public GameObject healing;

    //Nesnenin y ekseninde oluşabileceği sınır değerler
    float minPosY = -10;
    float maxPosY = 10;
    //sağ veya solda oluşumu random seçildikten sonra kullanılacak olan tutucu değişkenler.
    float maxPosX = 10;
    float minPosX = 6;
    //nesnenin oluşacağı z noktası.
    float z = 0f;

    GameObject CreateObjectThis;

    Vector3 newRandPos;

    void Start()
    {
        playerGameObject.SetActive(true);
        //2 saniye delaylı olarak, 2 saniyede 1 kere çalışması istenen fonksiyonun çağırılması.
        InvokeRepeating("CreateEnemy", 2, 2);
    }

    void CreateEnemy()
    {
        //Oluşturulacak rastgele nesnenin sayısı.
        int RandomCreate = Random.Range(1, 5);

        //Oluşturulacak nesnenin sol tarafta mı sağ tarafta mı oluşacağını belirleyen random tutucu
        int RandomCreateXPos = Random.RandomRange(1, 3);
        //Gelen randoma göre sol taraf veya sağ tarafı belirleyen maxPosX in belirleyicisi
        float tempx = Random.Range(6, 10);
        if (RandomCreateXPos == 1)
        {
            tempx *= -1;
        }


        //Oluşturulan Rastgele nesnelerin seçilimi.
        if (RandomCreate == 1)
        {
            // Oluşacak nesneyi belirtir.
            CreateObjectThis = enemy;
            //Oluşacak nesnenin konumunu random olarak belirler.
            newRandPos = new Vector3(tempx, Random.Range(minPosY, maxPosY), z);
        }
        else if (RandomCreate == 2)
        {
            CreateObjectThis = enemy2;
            newRandPos = new Vector3(tempx, Random.Range(minPosY, maxPosY), z);
        }
        else if (RandomCreate == 3)
        {
            CreateObjectThis = key;
            newRandPos = new Vector3(tempx, Random.Range(minPosY, maxPosY), z);
        }
        else
        {
            CreateObjectThis = healing;
            newRandPos = new Vector3(tempx, Random.Range(minPosY, maxPosY), z);

        }
        
        Instantiate(CreateObjectThis, newRandPos,CreateObjectThis.transform.rotation);
        
        
    }
}
