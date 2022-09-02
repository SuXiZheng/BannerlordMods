using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace ChineseWarband
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            InformationManager.DisplayMessage(new InformationMessage(new TextObject("{=5Ru6DbNctrkjzDs}Load Cinsese Weapons").ToString(), Color.White));
        }
    }
}
