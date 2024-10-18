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

        public static void 
        
        public static void ReturnHome()
        {
            buttonsType = 0;
        }
    }
}
