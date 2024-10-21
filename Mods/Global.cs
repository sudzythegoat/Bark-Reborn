using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    internal class Global
    {
        public static void LobbyInfo()
        {
            if (isModded)
            {
                int playerCount = 0;
                foreach (var player in PhotonNetwork.PlayerList)
                {
                    playerCount += 1;
                }
                NotifiLib.SendNotification($"Lobby: {PhotonNetwork.CurrentLobby} Name: {PhotonNetwork.Nickname} Player count: {playerCount}");
            }
        }

        public static void JoinRandom()
        {
            if (PhotonNetwork.InRoom)
            {
                PhotonNetwork.Disconnect();
                CoroutineManager.RunCoroutine(JoinRandomDelay());
                return;
            }

            string gamemode = PhotonNetworkController.Instance.currentJoinTrigger.networkZone;

            if (gamemode == "forest")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Forest, Tree Exit").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "city")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - City Front").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "canyons")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Canyon").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "mountains")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Mountain For Computer").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "beach")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Beach from Forest").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "sky")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Clouds").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "basement")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Basement For Computer").GetComponent<GorillaNetworkJoinTrigger>().OnBoxTriggered();
            }
            if (gamemode == "caves")
            {
                GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Cave").GetComponent<GorillaNetworkJoinTrigger>();
            }
        }

        public static IEnumerator JoinRandomDelay()
        {
            yield return new WaitForSeconds(1f);
            JoinRandom();
        }

        public static void 
        
        public static void ReturnHome()
        {
            buttonsType = 0;
        }
    }
}
