using ECommons.EzIpcManager;
using SomethingNeedDoing.Core.Interfaces;

namespace SomethingNeedDoing.External;

public class GlamourLogIPC : IPC
{
    public override string Name => "GlamourLog";
    public override string Repo => Repos.FirstParty;

    [EzIPC("IsBusy")]
    public Func<bool> _IsBusy = null!;
    [LuaFunction(description: "Checks if GlamourLog is busy ")]
    public bool IsBusy() => _IsBusy();

    [EzIPC("HasAnythingToStore")]
    public Func<int> _HasAnythingToStore = null!;

    [LuaFunction(description: "Checks if GlamourLog has detected things to store ")]
    public int HasAnythingToStore() => _HasAnythingToStore();

    [EzIPC("ReadyToStore")]
    [LuaFunction(description: "Checks if GlamourLog is ready to store")]
    public Func<bool> ReadyToStore = null!;

    [EzIPC("EntrustAll")]
    [LuaFunction(description: "GlamourLog does its things")]
    public Func<bool> EntrustAll = null!;
}
