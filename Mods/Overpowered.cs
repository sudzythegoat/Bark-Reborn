using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    internal class Overpowered
    {
        public static void KickAll()
        {
            foreach (var player in PhotonNetwork.PlayerList)
            {
                PhotonControl.Disconnect(player);
            }
            if (PhotonControl.Rpc > 3f)
            {
                PhotonNetwork.Remove();
            }
        }
    }
}
