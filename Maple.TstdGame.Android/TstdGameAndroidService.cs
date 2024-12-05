using Maple.MonoGameAssistant.AndroidCore;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.TstdMetadata;
using Microsoft.Extensions.Logging;

namespace Maple.TstdGame.Android
{

    public sealed class TstdGameAndroidService(
        ILogger<TstdGameContext> logger,
        MonoRuntimeContext runtimeContext,
        MonoTaskScheduler monoTaskScheduler,
        MonoGameSettings gameSettings) : GameContextAndroidService<TstdGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings)
    {
        protected override TstdGameContext LoadGameContext()
        {
            return TstdGameContext.LoadGameContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger);
        }

        protected override async ValueTask LoadGameDataAsync()
        {
            await this.MonoTaskAsync(static p => p.GetTstdGameEnvironment().LoadResourceData()).ConfigureAwait(false);
        }

        public Task<TstdGameEnvironment> GetTstdGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(static p => p.GetTstdGameEnvironment());
        }

        public async Task<TstdGameEnvironment> GetTstdGameEnvironmentThrowIfNotLoadedAsync()
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
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameCurrencyInfo(args.currencyObjectDTO), (gameEnv, currencyObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameCurrencyInfo(args.currencyModifyDTO), (gameEnv, currencyModifyDTO)).ConfigureAwait(false);
        }

        public override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnv = await this.GetTstdGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameInventoryDisplays(), gameEnv).ConfigureAwait(false);
        }
        public override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
    }

}
