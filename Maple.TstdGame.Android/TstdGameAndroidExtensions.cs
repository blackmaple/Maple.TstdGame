using Maple.MonoGameAssistant.AndroidCore.HostedService;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.AndroidWebApi;
using System.Runtime.InteropServices;

namespace Maple.TstdGame.Android
{
    public unsafe static partial class TstdGameAndroidExtensions
    {

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {

            return Maple.MonoGameAssistant.AndroidWebApi.AndroidExtensions.JNI_OnLoadImp(javaVM, reserved, static api =>
            api.CreateDefaultAndroidService(p =>
            {
                p.GameName = "吞食天地:刘蜀霸业";
                p.QQ = "^_^ QQ:75351663";
            }, p =>
            {
                AndroidExtensions.AddGameContextService<TstdGameAndroidService>(p);
            }));
        }



    }

}
