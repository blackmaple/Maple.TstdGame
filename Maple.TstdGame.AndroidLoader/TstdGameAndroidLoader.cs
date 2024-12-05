using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Logger;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;
using unsafe ApiActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JINT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;
using unsafe OnLoadDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JAVA_VM, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JINT>;
using unsafe OnUnloadDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JAVA_VM, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, void>;
using unsafe TestActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;

namespace Maple.TstdGame.AndroidLoader
{



    public unsafe static partial class TstdGameAndroidLoader
    {
        const string JavaClassFullName = "com/android/maple/service/MapleService";

        //const string AndroidDataPath = "/sdcard/Android/data";
        //const string PackageName = "com.guzz.lsby";
        //const string Mods = "maple";

        readonly struct Ptr_Func_ApiAction(nint ptr)
        {
            readonly ApiActionDelegate _ptr = (ApiActionDelegate)ptr;
            public static implicit operator nint(Ptr_Func_ApiAction func) => (nint)func._ptr;
            public static implicit operator bool(Ptr_Func_ApiAction func) => func != nint.Zero;
            public JBOOLEAN Invoke(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
                => _ptr(jniEnv, instance, actionIndex, json);

            public static Ptr_Func_ApiAction Create(ApiActionDelegate func) => new((nint)func);

        }

        readonly struct Ptr_Func_TestAction(nint ptr)
        {
            readonly TestActionDelegate _ptr = (TestActionDelegate)ptr;
            public static implicit operator nint(Ptr_Func_TestAction func) => (nint)func._ptr;
            public static implicit operator bool(Ptr_Func_TestAction func) => func != nint.Zero;


            public JBOOLEAN Invoke(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
                => _ptr(jniEnv, instance, text);

            public static Ptr_Func_TestAction Create(TestActionDelegate func) => new((nint)func);


        }

        readonly struct Ptr_Func_OnLoad(nint ptr)
        {
            readonly OnLoadDelegate _ptr = (OnLoadDelegate)ptr;
            public static implicit operator nint(Ptr_Func_OnLoad func) => (nint)func._ptr;
            public static implicit operator bool(Ptr_Func_OnLoad func) => func != nint.Zero;

            public JINT Invoke(PTR_JAVA_VM javaVM, JOBJECT reserved)
                => _ptr(javaVM, reserved);
        }

        readonly struct Ptr_Func_OnUnload(nint ptr)
        {
            readonly OnUnloadDelegate _ptr = (OnUnloadDelegate)ptr;
            public static implicit operator nint(Ptr_Func_OnUnload func) => (nint)func._ptr;
            public static implicit operator bool(Ptr_Func_OnUnload func) => func != nint.Zero;

            public void Invoke(PTR_JAVA_VM javaVM, JOBJECT reserved)
                 => _ptr(javaVM, reserved);

        }

        static Ptr_Func_ApiAction Func_ApiAction;
        static Ptr_Func_TestAction Func_TestAction;
        static Ptr_Func_OnLoad Func_OnLoad;
        static Ptr_Func_OnUnload Func_OnUnload;

        //    [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            ILogger logger = MonoGameLogger.Default;

            logger.LogInformation("1");
            if (NativeLibrary.TryLoad("libmaplecore.so", out var handle))
            {
                logger.LogInformation("3");

                logger.LogInformation("{P}", handle.ToString("X8"));
                //if (NativeLibrary.TryGetExport(handle, nameof(JNI_OnUnload), out var ptr_JNI_OnUnload))
                //{
                //    logger.LogInformation("{P}", ptr_JNI_OnUnload.ToString("X8"));

                //    Func_OnUnload = new Ptr_Func_OnUnload(ptr_JNI_OnUnload);
                //}
                //if (NativeLibrary.TryGetExport(handle, nameof(ApiAction), out var ptr_ApiAction))
                //{
                //    logger.LogInformation("{P}", ptr_ApiAction.ToString("X8"));
                //    Func_ApiAction = new Ptr_Func_ApiAction(ptr_ApiAction);
                //}
                //if (NativeLibrary.TryGetExport(handle, nameof(TestAction), out var ptr_TestAction))
                //{
                //    logger.LogInformation("{P}", ptr_TestAction.ToString("X8"));
                //    Func_TestAction = new Ptr_Func_TestAction(ptr_TestAction);
                //}
                if (NativeLibrary.TryGetExport(handle, nameof(JNI_OnLoad), out var ptr_JNI_OnLoad))
                {
                    logger.LogInformation("{P}", ptr_JNI_OnLoad.ToString("X8"));
                    Func_OnLoad = new Ptr_Func_OnLoad(ptr_JNI_OnLoad);
                    return Func_OnLoad.Invoke(javaVM, reserved);
                }

            }


            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        ////      [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
        //      public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        //      {
        //          if (Func_OnUnload)
        //          {
        //              Func_OnUnload.Invoke(javaVM, reserved);
        //          }
        //      }

        ////      [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
        //      public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        //          => Func_ApiAction ? Func_ApiAction.Invoke(jniEnv, instance, actionIndex, json) : false;

        ////      [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        //      public static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        //          => Func_TestAction ? Func_TestAction.Invoke(jniEnv, instance, text) : false;


    }



   
}
