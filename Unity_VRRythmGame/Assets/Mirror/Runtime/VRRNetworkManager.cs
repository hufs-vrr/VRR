﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> d1c3607ca05652511b7e7be9e9e7866d773bd161

namespace Mirror
{
    public class VRRNetworkManager : NetworkManager
    {
        [SyncVar]
        int playernum = 0;
        // 서버측에서 클라이언트가 접속했을 때의 콜백
        public override void OnServerConnect(NetworkConnection conn)
        {
            playernum += 1;
            base.OnServerConnect(conn);
<<<<<<< HEAD
            if (playernum >= 1)
=======
            if (playernum >= 2)
>>>>>>> d1c3607ca05652511b7e7be9e9e7866d773bd161
            {
                // spawnPrefabs에 등록된 프리팹을 스폰한다.
                GameObject charObj = Instantiate(spawnPrefabs[0], new Vector3(13,0,0), Quaternion.Euler(0,0,0));
                GameObject charObj2 = Instantiate(spawnPrefabs[0], new Vector3(-13,0,0), Quaternion.Euler(0,0,0));
                

                // 네트워크를 통해서 이 오브젝트가 생성되었음을 클라이언트에 알린다.
                NetworkServer.Spawn(charObj);
                NetworkServer.Spawn(charObj2);
            }
<<<<<<< HEAD
        }

        public override void OnStopHost()
        {
            SceneManager.LoadScene("Login");
        }

        public override void OnStopClient()
        {
            SceneManager.LoadScene("Login");
        }

=======
            
        }
>>>>>>> d1c3607ca05652511b7e7be9e9e7866d773bd161
    }
}