using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Runtime.InteropServices;

namespace Maple.TstdGame.AndroidLoader
{
    public unsafe static partial class TstdGameAndroidExport
    {

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
            => TstdGameAndroidLoader.JNI_OnLoad(javaVM, reserved);



        //[UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
        //public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        //    => TstdGameAndroidLoader.JNI_OnUnload(javaVM, reserved);


        //[UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
        //public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        //    => TstdGameAndroidLoader.ApiAction(jniEnv, instance, actionIndex, json);

        //[UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        //public static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING packageName)
        //    => TstdGameAndroidLoader.TestAction(jniEnv, instance, packageName);




    }


}
