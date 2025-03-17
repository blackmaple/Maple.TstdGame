using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.TstdGame.GameService
{
    internal static partial class TstdGameExtensions
    {


        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static int Maple()
        {
            RunWebApiService();
            static void RunWebApiService(int millisecondsDelay = 15 * 1000)
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
                Thread.Sleep(millisecondsDelay);
                webapp.Run();

            }
            return 1;
        }


    }
}
