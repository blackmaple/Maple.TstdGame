﻿using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.TstdGame.GameService
{
    internal static partial class TstdGameExtensions
    {
        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            _ = RunWebApiServiceAsync();

            static async Task RunWebApiServiceAsync(int millisecondsDelay = 15 * 1000)
            {

                var webapp = WebApiServiceExtensions.AsRunWebApiService(static p =>
                {
                    p.GameName = "吞食天地:刘蜀霸业";
                    p.MonoDataCollector = true;
                    p.QQ = "0";
                    p.Http = true;
                    p.AutoOpenUrl = true;
                    p.Port = 49009;
                }, static services => services.UseGameContextService<TstdGameService>());
                //延迟启动
                await Task.Delay(millisecondsDelay).ConfigureAwait(false);
                await webapp.RunAsync().ConfigureAwait(false);

            }

        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, uint ul_reason_for_call, nint lpReserved)
        {
            return InitDllMain(hModule, ul_reason_for_call, lpReserved);
        }


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("*")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool InitDllMain(nint hModule, uint ul_reason_for_call, nint lpReserved);

    }
}
