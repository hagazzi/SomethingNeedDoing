using ECommons.EzIpcManager;
using SomethingNeedDoing.Core.Interfaces;

namespace SomethingNeedDoing.External;

public class GlamourLogIPC : IPC
{
    public override string Name => "GlamourLog";
    public override string Repo => Repos.FirstParty;

    [EzIPC]
    [LuaFunction(description: "Checks if GlamourLog is busy ")]
    public Func<bool> IsBusy = null!;

    [EzIPC]
    public Func<int> _hasAnythingToStore = null!;  

    [LuaFunction(description: "Checks if GlamourLog has detected things to store ")]
    public int HasAnythingToStore() 
    {
        var result =  _hasAnythingToStore();
        Plugin.Log.Debug($"HasAnythingToStore -> {result}");
        return result
    }

    [EzIPC]
    [LuaFunction(description: "Checks if GlamourLog is ready to store")]
    public Func<bool> ReadyToStore = null!;

    [EzIPC]
    [LuaFunction(description: "GlamourLog does its things")]
    public Func<bool> EntrustAll = null!;
}
