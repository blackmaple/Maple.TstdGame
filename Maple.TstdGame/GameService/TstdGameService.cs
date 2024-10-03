using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Model;
using Maple.TstdGame.GameSourceGen;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.TstdGame.GameService
{

    internal sealed partial class TstdGameService(ILogger<TstdGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
        : GameContextService<TstdGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected sealed override TstdGameContext LoadGameContext()
        {
            return TstdGameContext.LoadGameContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger);
        }


        protected sealed override async ValueTask F5_KeyDown()
        {
            await  this.MonoTaskAsync(static p =>
            {
                var resources = p.ResourceManager._DICTIONARY4;
                if (resources.Valid())
                {
                    foreach (var resource in resources.AsRefArray())
                    {
                        var resKey = resource.Key.ToString();
                        var tags = resource.Value.AsRefArray();
                        foreach (var tag in tags)
                        {
                            p.Logger.LogInformation("res:{res}/tag:{tag}/tagid:{tagid}", resKey, tag.Key.ToString(), tag.Value.TAG.ToString());
                        }
                    }
                }


            }).ConfigureAwait(false);

        }
    }
}
