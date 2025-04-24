using Maple.MonoGameAssistant.AndroidCore.GameContext;
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

        //protected override async ValueTask LoadGameDataAsync()
        //{
        //    await this.MonoTaskAsync(static p => p.GetTstdGameEnvironment().LoadResourceData()).ConfigureAwait(false);
        //}

        public override async ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            //if (DateTime.Now.Year >= 2025 && DateTime.Now.Month > 5)
            //{
            //    return GameException.Throw<GameSessionInfoDTO>("修改器初始化失败,请联系管理员!");
            //}
            await this.MonoTaskAsync(static p => p.GetTstdGameEnvironment().CheckNetTime().LoadResourceDataIfThrowNotInit()).ConfigureAwait(false);
            return await base.GetSessionInfoAsync().ConfigureAwait(false);
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


        public override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, gameEnv) => gameEnv.GetGameCharacterDisplays().ToArray(), gameEnv).ConfigureAwait(false);
        }
        public override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameCharacterStatus(args.characterObjectDTO), (gameEnv, characterObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterObjectDTO)
        {
            var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameCharacterStatus(args.characterObjectDTO), (gameEnv, characterObjectDTO)).ConfigureAwait(false);
        }


        public override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return ValueTask.FromResult(TstdGameEnvironment.CacheSwitches);
        }

        public override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        {
            if (Enum.TryParse<EnumGameEquipmentEntrys>(gameSwitchModify.SwitchObjectId, out var _))
            {
                var gameEnv = await this.GetTstdGameEnvironmentAsync().ConfigureAwait(false);
                return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameSwitchDisplay(args.gameSwitchModify), (gameEnv, gameSwitchModify)).ConfigureAwait(false);
            }
            else
            {
                var gameEnv = await this.GetTstdGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
                return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameSwitchDisplay(args.gameSwitchModify), (gameEnv, gameSwitchModify)).ConfigureAwait(false);
            }
        }
    }

}
