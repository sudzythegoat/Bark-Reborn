using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    internal class Global
    {
        bool isModded = PhotonNetwork.InRoom && PhotonNetwork.CurrentRoom.CustomProperties.ToString().Contains("MODDED");
        
    }
}
