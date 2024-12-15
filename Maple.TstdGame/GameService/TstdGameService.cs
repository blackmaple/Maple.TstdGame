using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.TstdMetadata;
using Microsoft.Extensions.Logging;

namespace Maple.TstdGame.GameService
{

    internal sealed partial class TstdGameService(ILogger<TstdGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
        : GameContextService<TstdGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected sealed override TstdGameContext LoadGameContext()
        {
            return TstdGameContext.LoadGameContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger);
        }

        protected override async ValueTask LoadGameDataAsync()
        {
            await this.MonoTaskAsync(static p => p.GetTstdGameEnvironment().LoadResourceDataIfThrowNotInit()).ConfigureAwait(false);
        }

        public Task<TstdGameEnvironment> GetTstdGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(static p => p.GetTstdGameEnvironment());
        }

        public async Task<TstdGameEnvironment> GetTstdGameEnvironmentIfNotLoadedAsync()
        {
            var env = await this.MonoTaskAsync(p => p.GetTstdGameEnvironment()).ConfigureAwait(false);
            return env.InGame() ? env : GameException.ThrowIfNotLoaded<TstdGameEnvironment>();
        }

        public override async ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var gameEnv = await this.GetTstdGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameCurrencyDisplays(), gameEnv).ConfigureAwait(false);
        }
        public override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameCurrencyInfo(args.currencyObjectDTO), (gameEnv, currencyObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameCurrencyInfo(args.currencyModifyDTO), (gameEnv, currencyModifyDTO)).ConfigureAwait(false);
        }

        public override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnv = await this.GetTstdGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameInventoryDisplays(), gameEnv).ConfigureAwait(false);
        }
        public override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }

        protected sealed override async ValueTask F5_KeyDown()
        {


            await this.MonoTaskAsync((p) =>p.GetTstdGameEnvironment().WaitLoadResourceData()).ConfigureAwait(false);

            //await this.MonoTaskAsync(static p =>
            //{
            //    using var tagId = p.T2("maple");
            //    Character.Ptr_Character.LOAD_PLAYER_CHARACTER(tagId);
            //    Item.Ptr_Item.LOAD_EQUIPMENT(tagId);
            //    Item.Ptr_Item.LOAD_ITEM(tagId);


            //    var resources = p.ResourceManager._DICTIONARY4;
            //    if (resources.Valid())
            //    {
            //        foreach (var resource in resources.AsRefArray())
            //        {
            //            var resKey = resource.Key.ToString();
            //            var tags = resource.Value.AsRefArray();
            //            foreach (var tag in tags)
            //            {
            //                p.Logger.LogInformation("res:{res}/tag:{tag}/tagid:{tagid}", resKey, tag.Key.ToString(), tag.Value.TAG.ToString());
            //            }
            //        }
            //    }


            //}).ConfigureAwait(false);

        }
    }
}
